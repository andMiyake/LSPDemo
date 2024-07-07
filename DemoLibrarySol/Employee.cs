﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrarySol
{
    public class Employee : BaseEmployee, IManaged
    {
        public IEmployee Manager { get; set; }

        public virtual void AssignManager(IEmployee manager)
        {
            // Simulate doing other tasks here - otherwise, this should be
            // a property set statement, not a method.
            Manager = manager;
        }
    }
}
