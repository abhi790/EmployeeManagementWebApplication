using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ Id=1,Name="Abhimanyu",Department="HR", Email="abhi@example.com"},
                new Employee(){ Id=2,Name="Sajal",Department="IT", Email="sajal@example.com"},
                new Employee(){ Id=3,Name="Avisek",Department="IT", Email="avi@example.com"}
            };
        }

        //Get employee by id
        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(emp => emp.Id == id);
        }

        
    }

}
