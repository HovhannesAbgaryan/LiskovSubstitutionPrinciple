using DemoLibrary.Base;
using System;

namespace DemoLibrary.Entities
{
    /// <summary>
    /// CEO (manager entity)
    /// </summary>
    public class CEO : BaseEmployee, IManager
    {
        /// <summary>
        /// Calculate per hour rate
        /// </summary>
        /// <param name="rank">Rank</param>
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;

            Salary = baseAmount * rank;
        }

        /// <summary>
        /// Generate performance review
        /// </summary>
        public void GeneratePerformanceReview()
        {
            // Simulate reviewing a direct report
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }

        /// <summary>
        /// Firing
        /// </summary>
        public void FireSomeone()
        {
            // Simulate firing someone
            Console.WriteLine("You're Fired!");
        }
    }
}
