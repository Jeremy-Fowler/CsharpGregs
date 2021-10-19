using System;
using System.Collections.Generic;
using CsharpGregs.Models;

namespace CsharpGregs.Data
{
  public class FakeDb
  {
    private Random _random = new Random();
    public List<Car> Cars = new List<Car>();
    public List<House> Houses = new List<House>();
    public List<Job> Jobs = new List<Job>();
    public int GenerateId()
    {
      return _random.Next(100000, 1000000);
    }
  }
}