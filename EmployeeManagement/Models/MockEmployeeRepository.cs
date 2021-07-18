using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeesList;

        public MockEmployeeRepository()
        {
            _employeesList = new List<Employee>()
            {
                new Employee() {Id=1,Name="Mary",Department=Dept.HR,Email="Mary@Pradgim.com"},
                new Employee(){Id=2,Name="John",Department=Dept.IT,Email="John@Pradgim.com"},
                new Employee(){Id=3,Name="Sam",Department=Dept.IT,Email="Sam@Pradgim.com"}
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            //   return _employeesList.Select(x => x).ToList();
            return _employeesList;  
        }

        public Employee GetEmployee(int Id)
        {
            return _employeesList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
