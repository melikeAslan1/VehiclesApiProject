using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehiclesProject_BLL.Abstract;

namespace VehiclesProject_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id < 0)
            {
                throw new ArgumentException("id değeri negatif olamaz!");

            }
            await _carService.Delete(id);
            return Ok();

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var cars = await _carService.GetAll();

            return Ok(cars);
        }
    }
}
