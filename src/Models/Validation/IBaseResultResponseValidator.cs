using GetInfra.WebApi.Abstractions.Models.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace GetInfra.WebApi.Abstractions.Models.Validation
{
    public interface IBaseResultResponseValidator<T>
    {
        Task<BaseResultResponse> ValidateAsync(T entity, CancellationToken cancellation = default);
    }
}
