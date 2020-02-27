using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Entities
{
    public class EmployeesResponse
    {
        
            public string status { get; set; }
            public List<Employee> data { get; set; }
        
    }
}
