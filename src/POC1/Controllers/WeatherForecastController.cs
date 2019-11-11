using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS.Common.Definitions;
using CQRS.Common.Interfaces;
using Demo.Handlers.Grid;
using Demo.Models.Grid;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace POC1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IGridValueChangeCommandHandler gridValueChangedCommandChandler;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ObjectResult<GridResult>> Get()
        {
            var handler = new GridQueryHandler();

            return await handler.Handle(null);
        }

        [HttpPost]
        public async Task<Result> SetValue(GridValueChangeCommand query)
        {
            return await gridValueChangedCommandChandler.Handle(query);
        }
    }
}
