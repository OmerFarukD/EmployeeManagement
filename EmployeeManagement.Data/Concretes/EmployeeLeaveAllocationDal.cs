using EmployeeManagement.Data.Abstracts;
using EmployeeManagement.Data.DataContext;
using EmployeeManagement.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Data.Concretes
{
    public class EmployeeLeaveAllocationDal : EfRepository<EmployeeLeaveAllocation>, IEmployeeLeaveAllocationDal
    {
        private readonly EmployeeManagementContext _context;
        public EmployeeLeaveAllocationDal(EmployeeManagementContext context) : base(context)
        {
            _context = context;
        }
    }
}
