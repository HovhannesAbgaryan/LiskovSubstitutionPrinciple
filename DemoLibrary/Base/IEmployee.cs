namespace DemoLibrary.Base
{
    /// <summary>
    /// Interface for employee entities
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// First name
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        string LastName { get; set; }

        /// <summary>
        /// Salary
        /// </summary>
        decimal Salary { get; set; }

        /// <summary>
        /// Calculate per hour rate
        /// </summary>
        /// <param name="rank">Rank</param>
        void CalculatePerHourRate(int rank);
    }
}