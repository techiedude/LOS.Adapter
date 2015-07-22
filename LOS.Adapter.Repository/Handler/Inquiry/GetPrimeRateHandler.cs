
using System.Threading.Tasks;
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Query;
using LOS.Adapter.Data.Services.Repository;

namespace LOS.Adapter.Data.Services.Handler
{
    /// <summary>
    /// GetPrimeRateHandler
    /// </summary>
    public class GetPrimeRateHandler : IRequestHandler<GetPrimeRateRequest, GetPrimeRateResponse>
    {
        IInquiryRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPrimeRateHandler"/> class.
        /// </summary>
        public GetPrimeRateHandler()
        {
            _repo = new InquiryRepository();
        }


        /// <summary>
        /// Executes request asynchronously to get alternate name and address for obligor
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<GetPrimeRateResponse> ExecuteAsync(GetPrimeRateRequest request)
        {
            var resp = await Task.Factory.StartNew(() =>
                _repo.GetPrimeRate(request));

            return new GetPrimeRateResponse() { Errors = resp.Errors, LUW_RATE = resp.LUW_RATE };
        }

    }
}
