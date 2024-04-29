using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Constants;
using Shared.Exceptions;
using Shared.Exceptions.Models;

namespace API.Controllers
{
    [Route(DevConstants.BASE_URL)]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public AuthController()
        {
            
        }

        [HttpGet]
        public IActionResult Test()
        {
            try
            {
                throw new CustomException("Something went wrong", new CustomExceptionModel { Message = "Value", StatusCode = 200 });
            }
            catch (CustomException ex)
            {
                throw new CustomException(ex.Message, new CustomExceptionModel { Message = ex.Message, StatusCode = 200 });
            }
        }
    }
}
