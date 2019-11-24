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

        private readonly ILogger<WeatherForecastController> logger;

        private readonly IGridValueChangeCommandHandler gridValueChangedCommandChandler;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IGridValueChangeCommandHandler gridValueChangedCommandChandler)
        {
            this.logger = logger;
            this.gridValueChangedCommandChandler = gridValueChangedCommandChandler;
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
