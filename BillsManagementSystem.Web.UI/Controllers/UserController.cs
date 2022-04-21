using BillsManagementSystem.Business.Abstract;
using BillsManagementSystem.Model.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BillsManagementSystem.Web.UI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Post([FromForm] User user)
        {
            return Ok(user);
        }        

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok();
        }
    }
}
