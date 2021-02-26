namespace ApiCalculadora.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpPost]
        [Route("Add")]
        public int Add([FromHeader] int numA, [FromHeader] int numB)
        {
            return (numA + numB);
        }
        [HttpPost]
        [Route("Multiply")]
        public int Multiply([FromHeader] int numA, [FromHeader] int numB)
        {
            return (numA * numB);
        }
        [HttpPost]
        [Route("Divide")]
        public int Divide([FromHeader] int numA, [FromHeader] int numB)
        {
            return (numA / numB);
        }
        [HttpPost]
        [Route("Subtract")]
        public int Subtract([FromHeader] int numA, [FromHeader] int numB)
        {
            return (numA - numB);
        }
    }
}
