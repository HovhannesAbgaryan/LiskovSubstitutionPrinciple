using DemoLibrary.Base;
using System;

namespace DemoLibrary.Entities
{
    /// <summary>
    /// Manager (manager entity)
    /// </summary>
    public class Manager : Employee, IManager
    {
        /// <summary>
        /// Calculate per hour rate
        /// </summary>
        /// <param name="rank">Rank</param>
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 19.75M;

            Salary = baseAmount + (rank * 4);
        }

        /// <summary>
        /// Generate performance review
        /// </summary>
        public void GeneratePerformanceReview()
        {
            // Simulate reviewing a direct report
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }
    }
}
