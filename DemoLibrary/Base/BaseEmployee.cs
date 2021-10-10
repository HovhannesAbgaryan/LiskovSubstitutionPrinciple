namespace DemoLibrary.Base
{
    /// <summary>
    /// Base employee
    /// </summary>
    public abstract class BaseEmployee : IEmployee
    {
        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Salary
        /// </summary>
        public decimal Salary { get; set; }

        /// <summary>
        /// Calculate per hour rate
        /// </summary>
        /// <param name="rank">Rank</param>
        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 2);
        }
    }
}
