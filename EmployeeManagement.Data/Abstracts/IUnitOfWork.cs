using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Data.Abstracts
{
   public interface IUnitOfWork :IDisposable
    {
       IEmployeeLeaveAllocationDal employeeLeaveAllocationDal { get; }
       IEmployeeLeaveRequestDal employeeLeaveRequestDal { get;  }
         IEmployeeLeaveTypeDal employeeLeaveTypeDal { get; }
        void Save();
    }
}
