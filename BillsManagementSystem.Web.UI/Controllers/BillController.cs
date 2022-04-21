using BillsManagementSystem.Business.Abstract;
using BillsManagementSystem.Model.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BillsManagementSystem.Web.UI.Controllers
{
    public class BillController : Controller
    {
        private readonly IBillService billService;

        public BillController(IBillService billService)
        {
            this.billService = billService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Post([FromForm] Bill bill)
        {
            return Ok(bill);
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
