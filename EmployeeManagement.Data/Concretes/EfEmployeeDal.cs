using EmployeeManagement.Data.Abstracts;
using EmployeeManagement.Data.DataContext;
using EmployeeManagement.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EmployeeManagement.Data.Concretes
{
    public class EfEmployeeDal : EfRepository<Employee>, IEmployeeDal
    {
        private readonly EmployeeManagementContext _context;
        public EfEmployeeDal(EmployeeManagementContext context) : base(context)
        {
            _context = context;
        }
    }
}
