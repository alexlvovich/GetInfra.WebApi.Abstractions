using GetInfra.WebApi.Abstractions.Models.Validation;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GetInfra.WebApi.Abstractions.Models
{
    public class BaseResultResponse
    {
        /// <summary>
        /// Returns errors in case of failure
        /// </summary>
        public List<ErrorItem> Errors { get; set; }

        /// <summary>
        /// Return validation errors
        /// </summary>
        public List<ValidationErrorItem> ValidationErrors { get; set; }


        [JsonIgnore]
        public bool IsValid
        {
            get
            {
                if (ValidationErrors == null) return true;
                return ValidationErrors.Count == 0;
            }
        }

        [JsonIgnore]
        public bool Succeeded
        {
            get
            {
                if (ValidationErrors == null && Errors == null) return true;
                // if no validation errors and no execution errors occured and id generated the call is succesful 
                return ValidationErrors.Count == 0 && Errors.Count == 0;
            }
        }

    }
}
