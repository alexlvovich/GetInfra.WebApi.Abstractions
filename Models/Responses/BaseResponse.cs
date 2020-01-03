using GetInfra.WebApi.Abstractions.Validation;
using System.Collections.Generic;

namespace GetInfra.WebApi.Abstractions.Models.Responses
{
    /// <summary>
    /// base response class 
    /// </summary>
    public class BaseResponse
    {

        public BaseResponse()
        {
            Errors = new List<ErrorItem>();
            ValiationErrors = new List<ValidationErrorItem>();
        }
        /// <summary>
        /// Returns errors in case of failure
        /// </summary>
        public List<ErrorItem> Errors { get; set; }

        /// <summary>
        /// Return validation errors
        /// </summary>
        public List<ValidationErrorItem> ValiationErrors { get; set; }

        public bool IsValid
        {
            get
            {
                return ValiationErrors.Count == 0;
            }
        }

       
    }
}
