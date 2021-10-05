using GetInfra.WebApi.Abstractions.Models;
using GetInfra.WebApi.Abstractions.Models.Responses;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

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
    }
}
