
using System.Threading.Tasks;
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Query;
using LOS.Adapter.Data.Services.Repository;

namespace LOS.Adapter.Data.Services.Handler
{
    /// <summary>
    /// GetBillingSchedulesHandler
    /// </summary>
    public class GetBillingSchedulesHandler : IRequestHandler<GetBillingSchedulesRequest, GetBillingSchedulesResponse>
    {
        IInquiryRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBillingSchedulesHandler"/> class.
        /// </summary>
        public GetBillingSchedulesHandler()
        {
            _repo = new InquiryRepository();
        }



        public async Task<GetBillingSchedulesResponse> ExecuteAsync(GetBillingSchedulesRequest request)
        {
            var getBillingSchedules = await Task.Factory.StartNew(() =>
                _repo.GetBillingSchedules(request));

            return getBillingSchedules;
        }

    }
}
