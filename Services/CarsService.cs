using System.Collections.Generic;
using CsharpGregs.Data;
using CsharpGregs.Models;

namespace CsharpGregs.Services
{
  public class CarsService
  {
    private readonly FakeDb _db;

    public CarsService(FakeDb db)
    {
      _db = db;
    }

    public List<Car> Get()
    {
      return _db.Cars;
    }

    public Car Get(int carId)
    {
      var car = _db.Cars.Find(c => c.Id == carId);
      if (car == null)
      {
        throw new System.Exception("Invalid Car ID");
      }
      return car;
    }

    public Car CreateCar(Car carData)
    {
      carData.Id = _db.GenerateId();
      _db.Cars.Add(carData);
      return carData;
    }

    public Car EditCar(int carId, Car carData)
    {
      var car = Get(carId);
      car.Make = carData.Make ?? car.Make;
      car.Model = carData.Model ?? car.Model;
      car.Year = carData.Year;
      car.Price = carData.Price;
      car.ImgUrl = carData.ImgUrl ?? car.ImgUrl;
      car.Description = carData.Description ?? car.Description;
      return car;
    }

    public Car Delete(int carId)
    {
      var car = Get(carId);
      _db.Cars.Remove(car);
      return car;
    }
  }
}