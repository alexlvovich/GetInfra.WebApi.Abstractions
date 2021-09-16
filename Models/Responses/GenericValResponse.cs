using GetInfra.WebApi.Abstractions.Models.Validation;
using System.Collections.Generic;

namespace GetInfra.WebApi.Abstractions.Models.Responses
{
    /// <summary>
    /// representing value types as response
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericValResponse<T> : BaseResponse where T : struct
    {
        public GenericValResponse()
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
                return ValidationErrors.Count == 0 && Errors.Count == 0 && !EqualityComparer<T>.Default.Equals(Id, default(T));
            }
        }

       
    }
}
