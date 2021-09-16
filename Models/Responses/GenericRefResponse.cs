using GetInfra.WebApi.Abstractions.Models.Validation;
using System.Collections.Generic;

namespace GetInfra.WebApi.Abstractions.Models.Responses
{
    public class GenericRefResponse<T> : BaseResponse where T : class
    {
        public GenericRefResponse()
        {
            Errors = new List<ErrorItem>();
            ValidationErrors = new List<ValidationErrorItem>();
        }

        /// <summary>
        /// 
        /// </summary>
        public T Id { get; set; }

        public bool Succeeded
        {
            get
            {
                // if no validation errors and no execution errors occured and id generated the call is succesful 
                return ValidationErrors.Count == 0 && Errors.Count == 0 && Id != null;
            }
        }
    }
}
