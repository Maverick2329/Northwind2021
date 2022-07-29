using Microsoft.AspNetCore.Mvc;
using Northwind.Repository;
using Northwind.WEB.Models.ViewModels;
using Northwind.WEB.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.WEB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            Respuesta respuesta = new Respuesta();
            try
            {
                IEnumerable<EmployeeViewModel> employees = from e in _unitOfWork.Employees.Get()
                                                           select new EmployeeViewModel
                                                           {
                                                               EmployeeId = e.EmployeeId,
                                                               FirstName = e.FirstName,
                                                               LastName = e.LastName,
                                                               Title = e.Title
                                                           };
                respuesta.Win = 1;
                respuesta.Message = "Empleados Registrados";
                respuesta.Data = employees;
            }
            catch (Exception ex)
            {
                respuesta.Message = ex.Message;
            }
            return Ok(respuesta);           
        }
    }
}
