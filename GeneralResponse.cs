using GetInfra.WebApi.Abstractions.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetInfra.WebApi.Abstractions
{
    /// <summary>
    /// general api response with numeric id as return value
    /// </summary>
    public class GeneralResponse
    {
        public GeneralResponse()
        {
            Errors = new List<ErrorItem>();
            ValiationErrors = new List<ValidationErrorItem>();
        }
        public bool Succeeded
        {
            get
            {
                // if no validation errors and no execution errors occured and id generated the call is succesful 
                return ValiationErrors.Count == 0 && Errors.Count == 0;
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
        public List<ValidationErrorItem> ValiationErrors { get; set; }

        /// <summary>
        /// Returns if there are validation errors
        /// </summary>
        public bool IsValid
        {
            get
            {
                return ValiationErrors.Count == 0;
            }
        }

        public long NewId { get; set; }

    }
}
