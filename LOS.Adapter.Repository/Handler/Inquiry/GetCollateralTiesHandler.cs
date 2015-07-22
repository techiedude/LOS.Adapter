using System.Threading.Tasks;
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Query;
using LOS.Adapter.Data.Services.Repository;

namespace LOS.Adapter.Data.Services.Handler
{
    /// <summary>
    /// GetCollateralTiesHandler
    /// </summary>
    public class GetCollateralTiesHandler : IRequestHandler<GetCollateralTiesRequest, GetCollateralTiesResponse>
    {
        IInquiryRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:CollateralTiesHandler"/> class.
        /// </summary>
        public GetCollateralTiesHandler()
        {
            _repo = new InquiryRepository();
        }


        /// <summary>
        /// Executes the GetCollateralTies as asynchronous task.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<GetCollateralTiesResponse> ExecuteAsync(GetCollateralTiesRequest request)
        {
            var getCollateralTiesResponse = await Task.Factory.StartNew(() =>
                _repo.GetCollateralTies(request));

            return getCollateralTiesResponse;
        }

    }
}
