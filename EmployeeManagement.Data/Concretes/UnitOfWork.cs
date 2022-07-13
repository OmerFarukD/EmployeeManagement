using EmployeeManagement.Data.Abstracts;
using EmployeeManagement.Data.DataContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Data.Concretes
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeManagementContext _context;
        public UnitOfWork(EmployeeManagementContext context)
        {
            _context = context;
            employeeLeaveAllocationDal = new EmployeeLeaveAllocationDal(_context);
            employeeLeaveRequestDal = new EfEmployeeLeaveRequestDal(_context);
        }

        public IEmployeeLeaveAllocationDal employeeLeaveAllocationDal { get; private set; }
        public IEmployeeLeaveRequestDal employeeLeaveRequestDal { get; private set; }
        public IEmployeeLeaveTypeDal employeeLeaveTypeDal { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
