﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Bll.Models.WineDTOs;
using Restaurant.Bll.Services.Interfaces;
using Restaurant.Dal.Entities;

namespace Restaurant.API.Controllers
{
    [ApiController]
    public class WineController : ControllerBase
    {
        private readonly IWineService _wineService;
        private readonly ICloudImageService _cloudImageService;
        private readonly IMapper _mapper;

        public WineController(IWineService wineService, ICloudImageService cloudImageService, IMapper mapper)
        {
            this._wineService = wineService ?? throw new ArgumentNullException(nameof(wineService));
            this._cloudImageService = cloudImageService ?? throw new ArgumentNullException(nameof(cloudImageService));
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("api/wines")]
        public async Task<ActionResult<WineForListDTO>> GetWineList()
        {
            var wines = await _wineService.GetWineListAsync();

            return Ok(_mapper.Map<IEnumerable<WineForListDTO>>(wines));
        }
        [HttpGet("api/wines/{PositionId}", Name = "GetWine")]
        public async Task<ActionResult<WineDetailInfoDTO>> GetWine(Guid PositionId)
        {
            var wine = await _wineService.GetWineAsync(PositionId);
            if (wine == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<WineDetailInfoDTO>(wine));
        }

        [HttpPost("api/wines")]
        public async Task<ActionResult<WineDetailInfoDTO>> CreateWine([FromForm]WineCreationDTO wine)
        {
            var finalWine = _mapper.Map<Wine>(wine);
            //Add photo to db and get a link
            var photoLink = await _cloudImageService.UploadImageToCloud(wine.photo);
            //Add wine and link to db
            var wineAdded = await _wineService.AddWine(finalWine, photoLink);
            //SaveChanges
            await _wineService.SaveChangesAsync();
            //To return value
            var wineToReturn = _mapper.Map<WineDetailInfoDTO>(wineAdded);
            //CreatedAtRoute
            return CreatedAtRoute("GetWine", new {PositionId = wineToReturn.PositionId}, wineToReturn);
        }
    }
}