using System.Collections.Generic;
using CsharpGregs.Data;
using CsharpGregs.Models;

namespace CsharpGregs.Services
{
  public class HousesService
  {
    private readonly FakeDb _db;

    public HousesService(FakeDb db)
    {
      _db = db;
    }

    public List<House> Get()
    {
      return _db.Houses;
    }

    public House Get(int houseId)
    {
      var house = _db.Houses.Find(h => h.Id == houseId);
      if (house == null)
      {
        throw new System.Exception("Invalid House Id");
      }
      return house; 
    }

    public House CreateHouse(House houseData)
    {
      houseData.Id = _db.GenerateId();
      _db.Houses.Add(houseData);
      return houseData;
    }

    public House EditHouse(int houseId, House houseData)
    {
      var house = Get(houseId);
      house.Bedrooms = houseData.Bedrooms;
      house.Bathrooms = houseData.Bathrooms;
      house.Levels = houseData.Levels;
      house.Year = houseData.Year;
      house.Price = houseData.Price;
      house.ImgUrl = houseData.ImgUrl ?? house.ImgUrl;
      house.Description = houseData.Description ?? house.Description;
      return house;
    }

    public House DeleteHouse(int houseId)
    {
      var house = Get(houseId);
      _db.Houses.Remove(house);
      return house;
    }
  }
}