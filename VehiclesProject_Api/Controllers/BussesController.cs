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
    public class BussesController : ControllerBase
    {
        private IBusService _busService;

        public BussesController(IBusService busService)
        {
            _busService = busService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var buses = await _busService.GetAll();

            return Ok(buses);
        }
    }
}
