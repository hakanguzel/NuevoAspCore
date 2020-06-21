namespace NuevoAspCore.Models.Dtos
{
    public enum ApplicationState
    {
        /// <summary>
        /// Availability didn't check yet
        /// </summary>
        DidNotCheck = 0,

        /// <summary>
        /// Application available
        /// </summary>
        Available = 1,

        /// <summary>
        /// Application unavailble
        /// </summary>
        Unavailable = 2,

        /// <summary>
        /// Tried to check, but was completed with errors
        /// </summary>
        CheckedWithError = 3
    }
}
