using ConsoleToWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public List<EmployeeModel> GetEmployees()
        {
            return new List<EmployeeModel>() { 
                new EmployeeModel { Id = 1, Name = "Lucas"},
                new EmployeeModel { Id = 2, Name = "Julia"}
            };
        }

        [Route("{id}")]
        public IActionResult GetEmployees(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            return Ok(new List<EmployeeModel>() {
                new EmployeeModel { Id = 1, Name = "Lucas"},
                new EmployeeModel { Id = 2, Name = "Julia"}
            });
        }

        [Route("{id}/basic")]
        public ActionResult<EmployeeModel> GetEmployeesDetails(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            return new EmployeeModel() { Id = 1, Name = "Lucas" };
        }
    }
}
