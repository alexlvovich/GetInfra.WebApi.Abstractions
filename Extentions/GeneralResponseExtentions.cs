using GetInfra.WebApi.Abstractions.Models.Responses;
using System;

namespace GetInfra.WebApi.Abstractions.Extentions
{
    public static class GeneralResponseExtentions
    {
        public static GenericResponse<T> ToGenericResponse<T>(this GeneralResponse res)
           where T : IConvertible
        {
            var result = new GenericResponse<T>();

            result.Errors = res.Errors;
            result.ValiationErrors = res.ValiationErrors;
            result.Id = (T)Convert.ChangeType(res.NewId, typeof(T));

            return result;
        }
    }
}
