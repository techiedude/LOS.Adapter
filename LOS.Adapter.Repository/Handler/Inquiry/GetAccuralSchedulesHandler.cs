
using System.Threading.Tasks;
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Query;
using LOS.Adapter.Data.Services.Repository;

namespace LOS.Adapter.Data.Services.Handler
{
    /// <summary>
    /// GetAccrualSchedulesHandler
    /// </summary>
    public class GetAccrualSchedulesHandler : IRequestHandler<GetAccrualSchedulesRequest, GetAccrualSchedulesResponse>
    {
        IInquiryRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccrualSchedulesHandler"/> class.
        /// </summary>
        public GetAccrualSchedulesHandler()
        {
            _repo = new InquiryRepository();
        }


        /// <summary>
        /// Executes request asynchronously to get alternate name and address for obligor
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<GetAccrualSchedulesResponse> ExecuteAsync(GetAccrualSchedulesRequest request)
        {
            var getAccrualSchedules = await Task.Factory.StartNew(() =>
                _repo.GetAccrualSchedules(request));

            return getAccrualSchedules;
        }

    }
}
