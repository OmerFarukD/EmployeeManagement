using EmployeeManagement.BusinessEngine.Abstracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.UI.Controllers
{
    public class EmployeeLeaveTypesController : Controller
    {
        private readonly IEmployeeLeaveTypeService _employeeLeaveTypeService;
        public EmployeeLeaveTypesController(IEmployeeLeaveTypeService employeeLeaveTypeService)
        {
            _employeeLeaveTypeService = employeeLeaveTypeService;
        }
        public IActionResult Index()
        {
            var result = _employeeLeaveTypeService.GetAll();
            if (result.Success)
            {
                return View(result.Data);
            }
            return View();
        }
    }
}
