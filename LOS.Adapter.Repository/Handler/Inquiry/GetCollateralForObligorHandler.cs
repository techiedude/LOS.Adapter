using System.Threading.Tasks;
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Query;
using LOS.Adapter.Data.Services.Repository;

namespace LOS.Adapter.Data.Services.Handler
{
    public class GetCollateralForObligorHandler : IRequestHandler<GetCollateralForObligorRequest, GetCollateralForObligorResponse>
    {
        IInquiryRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:CollateralForObligorHandler"/> class.
        /// </summary>
        public GetCollateralForObligorHandler()
        {
            _repo = new InquiryRepository();
        }


        public async Task<GetCollateralForObligorResponse> ExecuteAsync(GetCollateralForObligorRequest request)
        {
            var getCollateralForObligorResponse = await Task.Factory.StartNew(() =>
                _repo.GetCollateralForObligor(request));

            return getCollateralForObligorResponse;
        }

    }
}
