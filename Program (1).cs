using System;
using System.Collections.Generic;

namespace inheritanceandpolymor
{
   public class Department
    {
        public int Depid { get; set; }
        public string DepartmentName { get; set; }

        public string EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public string GetDepartmentName()
        {
            DepartmentName = "ECE";

            return DepartmentName;
        }
        public int GetNumberofDepartments()
        {
            int Numberofdep = 0;

            Numberofdep = 1;

            return Numberofdep;


        }

        public virtual Department GetDepartmentDetails(int id)
        {

            Department dep1 = new Department()
            {
                Depid = 101,
                DepartmentName = "ECE",
                
            };
            return dep1;
        }
             

        static void Main(string[] args)
        {
            Employee emp = new Employee();
            int Did = 101;
            Department dep = new Department();

           Console.WriteLine(emp.GetDepartmentName());
            Console.WriteLine(emp.GetNumberofDepartments());
            Console.WriteLine(emp.GetEmployeeFirstName());
            Console.WriteLine(emp.GetEmployeeLastName());
            dep = emp.GetDepartmentDetails(Did);
            Console.WriteLine("Department ID :" +dep.Depid);
            Console.WriteLine("Department Name :" + dep.DepartmentName);

            Console.ReadLine();
        }
    }


    public class Employee:Department
    {
        public List<Department> DepartmentList = new List<Department>();
        public string  GetEmployeeFirstName()
        {
            //string FName = string.Empty;

            FirstName = "Uday";
            return FirstName;
                 
        }

        public string GetEmployeeLastName()
        {
            LastName="Kumar";
            return LastName;

        }
        public override Department GetDepartmentDetails(int id)
        {
            Department dep1 = new Department()
            {
                Depid = 101,
                DepartmentName = "Electronics and Communication Engineering",

            };
            return dep1;
        }


    }
 
}
