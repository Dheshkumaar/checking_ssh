using CarAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        public static Car obj = new Car();

        [HttpGet]
        [Route("Details")]
        public ActionResult<List<Car>> getAllCars()
        {
            return obj.getCars().ToList();
        }
        [HttpGet]
        [Route("getCar")]
        public ActionResult<Car> getCarById(int id)
        {
            obj = (from i in obj.getCars()
                   where i.CarNumber == id
                   select i).FirstOrDefault();
            if (obj == null)
                return NotFound();
            else
                return obj;
        }
        [HttpGet]
        [Route("getcarbybrand")]
        public ActionResult<List<Car>> getcarByBrand(string brandname)
        {
            var result = (from i in obj.getCars()
                   where i.Brand == brandname
                   select i).ToList();
            if (result == null)
                return NotFound();
            else
                return result;
        }
        [HttpPost]
        [Route("AddCar")]
        public ActionResult AddNewCar(Car c)
        {
            obj.AddCar(c);
            return Ok();
        }
        [HttpDelete]
        [Route("RemoveCar")]
        public ActionResult RemoveCar(int id)
        {
            obj.DeleteCar(id);
            return Ok();
        }

    }
}
