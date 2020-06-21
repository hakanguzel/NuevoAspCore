namespace NuevoAspCore.Models.Dtos
{
    public class CheckResult
    {
        /// <summary>
        /// Status of availability
        /// </summary>
        public ApplicationState State { get; set; }

        /// <summary>
        /// Flag, that indicates that there are some errors in http request
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
