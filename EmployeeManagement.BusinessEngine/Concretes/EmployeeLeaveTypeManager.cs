using AutoMapper;
using Core.Utilities.Results;
using EmployeeManagement.BusinessEngine.Abstracts;
using EmployeeManagement.BusinessEngine.Constants;
using EmployeeManagement.Common.VModels;
using EmployeeManagement.Data.Abstracts;
using EmployeeManagement.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagement.BusinessEngine.Concretes
{
   public class EmployeeLeaveTypeManager :IEmployeeLeaveTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeeLeaveTypeManager(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IDataResult<List<EmployeeLeaveTypeVM>> GetAll()
        {
            var data = _unitOfWork.employeeLeaveTypeDal.GetAll().ToList();
            var leaveType = _mapper.Map<List<EmployeeLeaveType>, List<EmployeeLeaveTypeVM>>(data);
            return new SuccessDataResult<List<EmployeeLeaveTypeVM>>(leaveType,Messages.OperationSuccessMessage);
            
        }

        
    }
}
