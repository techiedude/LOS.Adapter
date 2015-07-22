using System.Threading.Tasks;
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Query;
using LOS.Adapter.Data.Services.Repository;

namespace LOS.Adapter.Data.Services.Handler
{
    /// <summary>
    /// GetCollateralSupportingHandler
    /// </summary>
    public class GetCollateralSupportingHandler : IRequestHandler<GetCollateralSupportingRequest, GetCollateralSupportingResponse>
    {
        IInquiryRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:GetCollateralSupportingHandler"/> class.
        /// </summary>
        public GetCollateralSupportingHandler()
        {
            _repo = new InquiryRepository();
        }


        /// <summary>
        /// Executes the GetCollateralSupporting as asynchronous task.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<GetCollateralSupportingResponse> ExecuteAsync(GetCollateralSupportingRequest request)
        {
            var getCollateralSupportingResponse = await Task.Factory.StartNew(() =>
                _repo.GetCollateralSupportingObligation(request));

            return getCollateralSupportingResponse;
        }

    }
}
