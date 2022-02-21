using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples
{
    /// <summary>
    /// Without OCP
    /// CalculateBonus is to compute bonus based on salary
    /// </summary>
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee()
        {

        }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// Bonus is 10%
        /// </summary>
        /// <param name="salary"></param>
        /// <returns></returns>
        public decimal CalculateBonus(decimal salary)
        {
            return salary * 0.1M;
        }
    }


    // New Requirement: Based on EmployeeType Bonus should be given
    // Permanent: 10%, Contract: 5%
    // One way to solve this is adding a property called EmployeeType
    // and Modifying the logic of Calculate Bonus
    // But this violates the OCP and results in its corresponding drawbacks

    // To Support OCP, We need the Employee class
    // as follows

    /// <summary>
    /// Abstract base class
    /// This Employee class is Open for Extension (inheritance),
    /// closed for modification
    /// </summary>
    public abstract class EmployeeWithOCP
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public EmployeeWithOCP()
        {

        }

        public EmployeeWithOCP(int id, string name) 
        {
            Id = id;
            Name = name;
        }
        public abstract decimal CalculateBonus(decimal salary);
    }

    /// <summary>
    /// Will derive new class for each EmployeeType
    /// </summary>
    public class PermanentEmployee : EmployeeWithOCP
    {
        public PermanentEmployee(int id, string name): base(id, name)
        {

        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }

    public class ContractEmployee : EmployeeWithOCP
    {
        public ContractEmployee(int id, string name): base(id, name)
        {

        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.05M;
        }
    }

}
