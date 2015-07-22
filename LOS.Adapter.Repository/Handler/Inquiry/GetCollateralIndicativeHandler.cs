using System.Threading.Tasks;
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Query;
using LOS.Adapter.Data.Services.Repository;

namespace LOS.Adapter.Data.Services.Handler
{
    public class GetCollateralIndicativeHandler : IRequestHandler<GetCollateralIndicativeRequest, GetCollateralIndicativeResponse>
    {
        IInquiryRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:CollateralIndicativeHandler"/> class.
        /// </summary>
        public GetCollateralIndicativeHandler()
        {
            _repo = new InquiryRepository();
        }


        public async Task<GetCollateralIndicativeResponse> ExecuteAsync(GetCollateralIndicativeRequest request)
        {
            var getCollateralIndicativeResponse = await Task.Factory.StartNew(() =>
                _repo.GetCollateralIndicative(request));

            return getCollateralIndicativeResponse;
        }

    }
}
