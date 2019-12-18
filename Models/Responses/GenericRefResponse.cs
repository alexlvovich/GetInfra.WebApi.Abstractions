using GetInfra.WebApi.Abstractions.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetInfra.WebApi.Abstractions.Models.Responses
{
    public class GenericRefResponse<T> : BaseResponse where T : class
    {
        public GenericRefResponse()
        {
            Errors = new List<ErrorItem>();
            ValiationErrors = new List<ValidationErrorItem>();
        }

        /// <summary>
        /// 
        /// </summary>
        public T AssociatedId { get; set; }

        public bool Succeeded
        {
            get
            {
                // if no validation errors and no execution errors occured and id generated the call is succesful 
                return ValiationErrors.Count == 0 && Errors.Count == 0 && AssociatedId != null;
            }
        }
    }
}
