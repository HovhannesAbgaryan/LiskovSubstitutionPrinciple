namespace DemoLibrary.Base
{
    /// <summary>
    /// Interface for managed entities
    /// </summary>
    public interface IManaged : IEmployee
    {
        /// <summary>
        /// Manager to manage the entity
        /// </summary>
        IEmployee Manager { get; set; }

        /// <summary>
        /// Assign manager to manage the entity
        /// </summary>
        /// <param name="manager">Manager to manage the entity</param>
        void AssignManager(IEmployee manager);
    }
}
