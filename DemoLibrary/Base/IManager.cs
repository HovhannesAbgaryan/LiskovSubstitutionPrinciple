namespace DemoLibrary.Base
{
    /// <summary>
    /// Interface for manager entities
    /// </summary>
    public interface IManager : IEmployee
    {
        /// <summary>
        /// Generate performance review
        /// </summary>
        void GeneratePerformanceReview();
    }
}
