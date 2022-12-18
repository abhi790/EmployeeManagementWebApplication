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
                new Employee(){ Id=1,Name="Abhimanyu",Department=Dept.HR, Email="abhi@example.com"},
                new Employee(){ Id=2,Name="Sajal",Department=Dept.IT, Email="sajal@example.com"},
                new Employee(){ Id=3,Name="Avisek",Department=Dept.IT, Email="avi@example.com"}
            };
        }

        public Employee Add(Employee employee)
        {
           employee.Id =  _employeeList.Max(e => e.Id)+1;
           _employeeList.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee deleteEmp = _employeeList.FirstOrDefault(e => e.Id == id);
            if(deleteEmp != null)
            {
                _employeeList.Remove(deleteEmp);
            }
            return deleteEmp;
        }

        public Employee Edit(Employee employee)
        {
            Employee editEmp = _employeeList.FirstOrDefault(e => e.Id == employee.Id);
            if (editEmp != null)
            {
                editEmp.Name = employee.Name;
                editEmp.Email = employee.Email;
                editEmp.Department = employee.Department;
            }
            return editEmp;
        }

        //Get all employee
        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        //Get employee by id
        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(emp => emp.Id == id);
        }

        
    }

}
