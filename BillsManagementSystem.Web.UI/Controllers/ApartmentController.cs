using BillsManagementSystem.Business.Abstract;
using BillsManagementSystem.Model.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BillsManagementSystem.Web.UI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : Controller
    {
        private readonly IApartmentService apartmentService;

        public ApartmentController(IApartmentService apartmentService)
        {
            this.apartmentService = apartmentService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Post([FromForm] Apartment apartment)
        {
            return Ok(apartment);
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
