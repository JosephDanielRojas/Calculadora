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
            if(numB==0)
            {
                return 0;
            }
            return (numA / numB);
        }
        [HttpPost]
        [Route("Subtract")]
        public int Subtract([FromHeader] int numA, [FromHeader] int numB)
        {
            return (numA - numB);
        }

        [HttpGet]
        [Route("Add")]
        public int Add2( int numA, int numB)
        {
            return (numA + numB);
        }
        [HttpGet]
        [Route("Multiply")]
        public int Multiply2( int numA, int numB)
        {
            return (numA * numB);
        }
        [HttpGet]
        [Route("Divide")]
        public int Divide2(int numA, int numB)
        {
            if (numB == 0)
            {
                return 0;
            }
            return (numA / numB);
        }
        [HttpGet]
        [Route("Subtract")]
        public int Subtract2(int numA, int numB)
        {
            return (numA - numB);
        }
    }
}
