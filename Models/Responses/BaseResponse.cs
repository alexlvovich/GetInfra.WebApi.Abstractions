using GetInfra.WebApi.Abstractions.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetInfra.WebApi.Abstractions.Models.Responses
{
    /// <summary>
    /// base response class 
    /// </summary>
    public class BaseResponse
    {
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
