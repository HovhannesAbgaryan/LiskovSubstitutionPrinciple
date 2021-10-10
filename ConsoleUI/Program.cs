using DemoLibrary.Base;
using DemoLibrary.Entities;
using System;

namespace ConsoleUI
{
    class Program
    {
        /// <summary>
        /// Welcome message
        /// </summary>
        static void WelcomeMessage()
        {
            Console.WriteLine("SOLID Principles");
            Console.WriteLine("The L in SOLID - Liskov Substitution Principle (LSP)");
            Console.WriteLine("Welcome to LSPDemo application!");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //Display welcome message
            WelcomeMessage();

            #region CEO

            //Create CEO
            IManager ceo = new CEO
            {
                FirstName = "Tony",
                LastName = "Stark"
            };

            //Calculate per hour rate for CEO
            ceo.CalculatePerHourRate(6);

            //Print information about CEO
            Console.WriteLine($"CEO: {ceo.FirstName} {ceo.LastName}. Salary: ${ceo.Salary}/hour");

            #endregion CEO

            #region Manager

            //Create manager
            IManaged manager = new Manager
            {
                FirstName = "Emma",
                LastName = "Stone"
            };

            //Assign CEO to manage the manager
            manager.AssignManager(ceo);

            //Calculate per hour rate for manager
            manager.CalculatePerHourRate(4);

            //Print information about manager
            Console.WriteLine($"Manager: {manager.FirstName} {manager.LastName}. Salary: ${manager.Salary}/hour");

            #endregion Manager

            #region Employee

            //Create employee
            IManaged employee = new Employee
            {
                FirstName = "Tim",
                LastName = "Corey"
            };

            //Assign manager to manage the employee
            employee.AssignManager(manager);

            //Calculate per hour rate for employee
            employee.CalculatePerHourRate(2);

            //Print information about employee
            Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}. Salary: ${employee.Salary}/hour");

            #endregion Employee
        }
    }
}
