using System;
using System.Collections.Generic;
using Core.BusinessService.Interface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model;

namespace Core.Controllers
{
    [EnableCors("CorsPolicy")]
    public class NpvController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly INPVCalculatorService _nPVCalculatorService;
        public NpvController(ILogger<NpvController> logger, INPVCalculatorService nPVCalculatorService)
        {
            _logger = logger;
            _nPVCalculatorService = nPVCalculatorService;
        }

        [HttpPost]
        [Route("npv/calculatenpv")]
        public ActionResult<decimal> GetNpv([FromBody] NpvEntity npv)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return _nPVCalculatorService.GetNPV(npv.discountRate, npv.lowerBoundRate, npv.upperBoundRate);
        }

        [HttpGet]
        [Route("npv/test")]

        public  IEnumerable<string> Get()
        {

            return new string[] { "a", "b", "c" };
        }

    }
}
