﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Data.Abstracts
{
   public interface IUnitOfWork :IDisposable
    {
        void Save();
    }
}