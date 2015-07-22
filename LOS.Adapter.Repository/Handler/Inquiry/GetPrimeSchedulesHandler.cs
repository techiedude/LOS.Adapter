
using System.Threading.Tasks;
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Query;
using LOS.Adapter.Data.Services.Repository;

namespace LOS.Adapter.Data.Services.Handler
{
    /// <summary>
    /// GetPrimeSchedulesHandler
    /// </summary>
    public class GetPrimeSchedulesHandler : IRequestHandler<GetPrimeSchedulesRequest, GetPrimeSchedulesResponse>
    {
        IInquiryRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPrimeSchedulesHandler"/> class.
        /// </summary>
        public GetPrimeSchedulesHandler()
        {
            _repo = new InquiryRepository();
        }


        /// <summary>
        /// Executes request asynchronously to get alternate name and address for obligor
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<GetPrimeSchedulesResponse> ExecuteAsync(GetPrimeSchedulesRequest request)
        {
            var getPrimeSchedules = await Task.Factory.StartNew(() =>
                _repo.GetPrimeSchedules(request));

            return getPrimeSchedules;
        }

    }
}
