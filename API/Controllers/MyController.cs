using BMIModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyLogic;
using MyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private readonly ILogic _logic;
        public MyController(ILogic logic)
        {
            _logic = logic;
        }

        [HttpPost]
        public IActionResult Formula(FormulaViewModel model)
        {
            var respond = _logic.Formula(model);
            return Ok(respond);
        }

        [HttpPost]
        public IActionResult multiply(MultiplyViewModel model)
        {
            var reply = _logic.multiply(model);
            return Ok(reply);
        }

    }
}
