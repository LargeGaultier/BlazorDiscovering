using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Entities
{
    public class EmployeeDetailsResponse
    {
        public string status { get; set; }
        public Employee data { get; set; }
    }
}
