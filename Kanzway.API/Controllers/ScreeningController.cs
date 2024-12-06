using Asp.Versioning;
using Kanzway.API.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Kanzway.API.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v1/[controller]")]
    public class ScreeningController : ControllerBase
    {
        /// <summary>
        /// Get the list from 1 to the specified number
        /// </summary>
        /// <param name="number">should be greater than or equal to 1</param>
        ///<response code = "200" > Returns the List of numbers</response>
        /// <response code="400">Returns a handled error happen</response>
        /// <response code="500">Returns an unhandled error happen</response>
        /// <exception cref="BusinessRuleException"></exception>
        [Route("{number}")]
        [HttpGet]
        public IActionResult Index(int number)
        {
            if (number < 1)
            {
               throw new BusinessRuleException("Input should be Greater than or Equal to 1");
            }
            List<string> numberList = new List<string>();
            for(int i = 1; i<= number; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    numberList.Add("KanzWay");
                }
                else if(i % 3 == 0)
                {
                    numberList.Add("Kanz");
                }
                else if(i % 5 == 0)
                {
                    numberList.Add("Way");
                }
                else
                {
                    numberList.Add(i.ToString());
                }
            }
            return Ok(numberList);
        }
    }
}
