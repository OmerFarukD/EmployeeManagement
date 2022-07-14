using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.Common.VModels
{
   public class EmployeeLeaveTypeVM :BaseVM
    {
        [Required]
        public string Name { get; protected set; }

        public int DefaultDays { get; protected set; }

        public DateTime DateCreated { get; protected set; }
    }
}
