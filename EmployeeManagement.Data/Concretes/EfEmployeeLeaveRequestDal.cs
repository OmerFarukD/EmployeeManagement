using EmployeeManagement.Data.Abstracts;
using EmployeeManagement.Data.DataContext;
using EmployeeManagement.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Data.Concretes
{
   public class EfEmployeeLeaveRequestDal : EfRepository<EmployeeLeaveRequest> ,IEmployeeLeaveRequestDal
    {
        private readonly EmployeeManagementContext _context;
        public EfEmployeeLeaveRequestDal(EmployeeManagementContext context):base(context)
        {
            _context = context;
        }
    }
}
