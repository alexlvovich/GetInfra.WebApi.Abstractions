using GetInfra.WebApi.Abstractions.Models.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace GetInfra.WebApi.Abstractions.Models.Validation
{
    public interface IValidator<T>
    {
        Task<BaseResponse> ValidateAsync(T entity, CancellationToken cancellation = new CancellationToken());

        Task<BaseResultResponse> ValidateAsync(T entity);
    }
}
