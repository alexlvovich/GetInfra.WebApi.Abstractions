using GetInfra.WebApi.Abstractions.Models.Responses;
using System;

namespace GetInfra.WebApi.Abstractions.Extentions
{
    public static class GenericResponseExtentions
    {
        public static GeneralResponse ToGeneralResponse<T>(this GenericResponse<T> res)
           where T : IConvertible
        {
            var result = new GeneralResponse();

            result.Errors = res.Errors;
            result.ValidationErrors = res.ValidationErrors;
            result.NewId = (long)Convert.ChangeType(res.Id, typeof(long));

            return result;
        }
    }
}
