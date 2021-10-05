using GetInfra.WebApi.Abstractions.Models.Validation;
using System;
using System.Collections.Generic;

namespace GetInfra.WebApi.Abstractions.Models.Responses
{
    /// <summary>
    /// general api response with numeric id as return value
    /// </summary>
    public class GeneralResponse
    {
        public GeneralResponse()
        {
            Errors = new List<ErrorItem>();
            ValidationErrors = new List<ValidationErrorItem>();
        }
        public bool Succeeded
        {
            get
            {
                // if no validation errors and no execution errors occured and id generated the call is succesful 
                return ValidationErrors.Count == 0 && Errors.Count == 0;
            }
        }

        [Obsolete("Will be removed in next versions")]
        public string Msg { get; set; }

        /// <summary>
        /// Returns errors in case of failure
        /// </summary>
        public List<ErrorItem> Errors { get; set; }

        /// <summary>
        /// Return validation errors
        /// </summary>
        public List<ValidationErrorItem> ValidationErrors { get; set; }

        /// <summary>
        /// Returns if there are validation errors
        /// </summary>
        public bool IsValid
        {
            get
            {
                return ValidationErrors.Count == 0;
            }
        }

        public long NewId { get; set; }

    }
}
