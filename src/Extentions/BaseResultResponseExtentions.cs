using GetInfra.WebApi.Abstractions.Models;
using GetInfra.WebApi.Abstractions.Models.Responses;
using GetInfra.WebApi.Abstractions.Models.Validation;
using System.Collections.Generic;

namespace GetInfra.WebApi.Abstractions.Extentions
{
    /// <summary>
    /// converting from one responce to another
    /// </summary>
    public static class BaseResultResponseExtentions
    {
      
        public static GenericResultResponse<T> ToGenericResultResponse<T>(this BaseResultResponse res)
       where T : notnull
        {
            var result = new GenericResultResponse<T>();

            result.Errors = res.Errors;
            result.ValidationErrors = res.ValidationErrors;
            return result;
        }

        public static void SafeAddValidationError(this BaseResultResponse response, ValidationErrorItem error)
        {
            if (response.ValidationErrors == null) response.ValidationErrors = new List<ValidationErrorItem>();

            response.ValidationErrors.Add(error);
        }

        public static void SafeAddError(this BaseResultResponse response, ErrorItem error)
        {
            if (response.Errors == null) response.Errors = new List<ErrorItem>();

            response.Errors.Add(error);
        }
    }
}
