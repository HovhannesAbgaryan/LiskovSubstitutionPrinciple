using DemoLibrary.Base;

namespace DemoLibrary.Entities
{
    /// <summary>
    /// Employee (managed entity)
    /// </summary>
    public class Employee : BaseEmployee, IManaged
    {
        /// <summary>
        /// Manager to manage the employee
        /// </summary>
        public IEmployee Manager { get; set; } = null;

        /// <summary>
        /// Assign manager to manage the employee
        /// </summary>
        /// <param name="manager">Manager to manage the employee</param>
        public void AssignManager(IEmployee manager)
        {
            // Simulate doing other tasks here - otherwise, this should be a property set statement, not a method.
            Manager = manager;
        }
    }
}
