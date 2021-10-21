using GetInfra.WebApi.Abstractions.Models;
using GetInfra.WebApi.Abstractions.Models.Responses;
using GetInfra.WebApi.Abstractions.Models.Validation;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;

namespace GetInfra.WebApi.Abstractions.Extentions
{
    public static class GenericResultResponseExtentions
    {
        //public static GeneralResponse ToGeneralResponse<T>(this GenericResponse<T> res)
        //   where T : IConvertible
        //{
        //    var result = new GeneralResponse();

        //    result.Errors = res.Errors;
        //    result.ValidationErrors = res.ValidationErrors;
        //    result.NewId = (long)Convert.ChangeType(res.Id, typeof(long));

        //    return result;
        //}

        public static string AsJson<T>(this GenericResultResponse<T> response)
        {
            var str = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.None,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                });

            return str;
        }

        public static void SafeAddError<T>(this GenericResultResponse<T> response, ErrorItem error)
        {
            if (response.Errors == null) response.Errors = new List<ErrorItem>();

            response.Errors.Add(error);
        }

        public static void SafeAddValidationError<T>(this GenericResultResponse<T> response, ValidationErrorItem error)
        {
            if (response.ValidationErrors == null) response.ValidationErrors = new List<ValidationErrorItem>();

            response.ValidationErrors.Add(error);
        }
    }
}
