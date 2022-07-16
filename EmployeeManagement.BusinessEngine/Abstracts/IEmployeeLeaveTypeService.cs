using Core.Utilities.Results;
using EmployeeManagement.Common.VModels;
using EmployeeManagement.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.BusinessEngine.Abstracts
{
  public interface IEmployeeLeaveTypeService
    {
        IDataResult<List<EmployeeLeaveTypeVM>> GetAll();

    }
}
