
using Microsoft.AspNetCore.Mvc;

namespace CDF.Net.Core.ASPNet
{
    /// <summary>
    /// A data class that captures a <see cref="ProblemDetails"/> information and returns it in an object based action result.
    /// </summary>
    public class ProblemObjectResult:ObjectResult
    {
        /// <summary>
        /// Creates a new instance of the <see cref="ProblemObjectResult"/>
        /// </summary>
        /// <param name="problem">The problem to be included in the result;</param>
        public ProblemObjectResult(ProblemDetails problem)
            : base(problem)
        {
            StatusCode = problem.Status;
        }

    }
}
