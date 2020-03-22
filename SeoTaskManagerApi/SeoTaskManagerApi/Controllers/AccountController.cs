using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SeoTaskManagerApi.Models;

namespace SeoTaskManagerApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : BaseApiController
    {
        // POST: api/UserAccount/Register
        /// <summary>
        /// Just registration
        /// </summary>
        /// <param name="useRegistrationModel"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Register([FromBody] UserRegistrationModel useRegistrationModel)
        {
            return Ok();
        }

        // POST: api/UserAccount/SignIn
        /// <summary>
        /// Returns JWT Bearer token
        /// </summary>
        /// <param name="userLoginModel"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        public string SignIn([FromBody] UserLoginModel userLoginModel)
        {
            return "Bearer xxx";
        }

        // POST: api/UserAccount/SignOut
        /// <summary>
        /// Just sign out
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult SignOut()
        {
            return Ok();
        }

        // GET: api/UserAccount/ChangePassword
        /// <summary>
        /// Just change password
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet]
        public IActionResult ChangePassword()
        {
            return Ok();
        }
    }
}