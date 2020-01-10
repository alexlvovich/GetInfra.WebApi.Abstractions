using GetInfra.WebApi.Abstractions.Validation;
using System;
using System.Collections.Generic;

namespace GetInfra.WebApi.Abstractions.Models.Responses
{
    /// <summary>
    /// generic api response with IConvrtable (primitives data types) as return value
    /// </summary>
    public class GenericResponse<T> : BaseResponse where T : notnull
    {
        public GenericResponse()
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

        public T Id { get; set; }

    }
}
