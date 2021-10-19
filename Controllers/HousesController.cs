using System.Collections.Generic;
using CsharpGregs.Models;
using CsharpGregs.Services;
using Microsoft.AspNetCore.Mvc;

namespace CsharpGregs.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class HousesController : ControllerBase
  {
    private readonly HousesService _hs;

    public HousesController(HousesService hs)
    {
      _hs = hs;
    }

    [HttpGet]
    public ActionResult<List<House>> GetHouses()
    {
      try
      {
           var houses = _hs.Get();
           return Ok(houses);
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    [HttpGet("{houseId}")]
    public ActionResult<House> GetHouseById(int houseId)
    {
      try
      {
           var house = _hs.Get(houseId);
           return Ok(house);
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<House> CreateHouse([FromBody] House houseData)
    {
      try
      {
           var house = _hs.CreateHouse(houseData);
           return Ok(house);
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    [HttpPut("{houseId}")]
    public ActionResult<House> EditHouse(int houseId, [FromBody] House houseData)
    {
      try
      {
           var house = _hs.EditHouse(houseId, houseData);
           return Ok(house);
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    [HttpDelete("{houseId}")]
    public ActionResult<House> DeleteHouse(int houseId)
    {
      try
      {
           var house = _hs.DeleteHouse(houseId);
           return Ok(house);
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }
  }
}