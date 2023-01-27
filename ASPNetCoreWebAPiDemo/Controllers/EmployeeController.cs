using ASPNetCoreWebAPiDemo.Models;
using ASPNetCoreWebAPiDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreWebAPiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService service)
        {
            _employeeService = service;
        }

        /// <summary>
        /// get all employess
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAllEmployees()
        {
            try
            {
                var employees = _employeeService.GetEmployeesList();
                if (employees == null)
                    return NotFound();
                return Ok(employees);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        /// <summary>
        /// get employee details by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]/id")]
        public IActionResult GetEmployeesById(int id)
        {
            try
            {
                var employees = _employeeService.GetEmployeeDetailsById(id);
                if (employees == null)
                    return NotFound();
                return Ok(employees);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        /// <summary>
        /// save employee
        /// </summary>
        /// <param name="employeeModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public IActionResult SaveEmployees(Employees employeeModel)
        {
            try
            {
                var model = _employeeService.SaveEmployee(employeeModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// delete employee  
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("[action]")]
        public IActionResult DeleteEmployee(int id)
        {
            try
            {
                var model = _employeeService.DeleteEmployee(id);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
