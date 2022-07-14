﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Common.VModels
{
  public class EmployeeLeaveRequestVM :BaseVM
    {
        //********************************************************************************//

        //Talepte bulunan kullanıcı.
        public string RequestingEmployeeId { get; set; }
      
        public EmployeeVM RequestingEmployeeVm { get; set; }

        //Onaylayan kullanıcı.
        public string ApprovedEmployeeId { get; set; }
       
        public EmployeeVM ApprovedEmployeeVm { get; set; }

        public int EmployeeLeaveTypeId { get; set; }
        public EmployeeLeaveTypeVM employeeLeaveTypeVm { get; set; }

        //********************************************************************************//

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestComments { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
    }
}
