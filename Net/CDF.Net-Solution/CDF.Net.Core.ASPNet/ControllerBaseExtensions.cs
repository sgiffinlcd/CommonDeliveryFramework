using Microsoft.AspNetCore.Mvc;
using CDF.Net.Exceptions;

namespace CDF.Net.Core.ASPNet
{
    /// <summary>
    /// Extensions class that extends the ASP.Net core <see cref="ControllerBase"/> class.
    /// These extensions roll up integration of utilities library functionality and makes them available to web api controllers.
    /// </summary>
    public static class ControllerBaseExtensions
    {
        public static ProblemObjectResult CreateProblemResult(this ControllerBase source, ManagedException exception)
        {
            if (exception == null | source == null)
            {

                return CreateGenericInternalServerErrorProblemResult();
            }

            ProblemDetails problem = null;

            switch (exception)
            {
                case AuthenticationException authenticationException:
                    problem = authenticationException.GetProblemDetails(source);
                    break;
                case AuthorizationException authorizationException:
                    problem = authorizationException.GetProblemDetails(source);
                    break;
                case ExternalAccessDeniedException accessDeniedException:
                    problem = accessDeniedException.GetProblemDetails(source);
                    break;
                case SecurityException securityException:
                    problem = securityException.GetProblemDetails(source);
                    break;
                case CDF.Net.Exceptions.TimeoutException timeoutException:
                    problem = timeoutException.GetProblemDetails(source);
                    break;
                case CommunicationsException communicationsException:
                    problem = communicationsException.GetProblemDetails(source);
                    break;
                case ConfigurationException configurationException:
                    problem = configurationException.GetProblemDetails(source);
                    break;
                case DataValidationException dataValidationException:
                    problem = dataValidationException.GetProblemDetails(source);
                    break;
                case DataException dataException:
                    problem = dataException.GetProblemDetails(source);
                    break;
                case UnhandledLogicException unhandledLogicException:
                    problem = unhandledLogicException.GetProblemDetails(source);
                    break;
                case LogicException logicException:
                    problem = logicException.GetProblemDetails(source);
                    break;
                default:
                    problem = exception.GetProblemDetails(source);
                    break;
            }

            return problem != null ? new ProblemObjectResult(problem) : CreateGenericInternalServerErrorProblemResult();
        }


        /// <summary>
        /// Static helper method to create a generic internal server error problem.
        /// </summary>
        /// <returns>Generic internal server error problem as a action result.</returns>
        private static ProblemObjectResult CreateGenericInternalServerErrorProblemResult()
        {
            var problem = new ProblemDetails
                { Type = "https://httpstatuses.com/500", Status = 500, Title = "Internal Server Error", Detail = "An internal error has occured and the operation could not complete." };

            return new ProblemObjectResult(problem);
        }


    }
}
