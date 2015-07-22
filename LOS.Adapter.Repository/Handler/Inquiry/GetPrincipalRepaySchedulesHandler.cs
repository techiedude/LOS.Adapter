
using System.Threading.Tasks;
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Query;
using LOS.Adapter.Data.Services.Repository;

namespace LOS.Adapter.Data.Services.Handler
{
    /// <summary>
    /// GetPrincipalRepaySchedulesHandler
    /// </summary>
    public class GetPrincipalRepaySchedulesHandler : IRequestHandler<GetPrincipalRepaySchedulesRequest, GetPrincipalRepaySchedulesResponse>
    {
        IInquiryRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPrincipalRepaySchedulesHandler"/> class.
        /// </summary>
        public GetPrincipalRepaySchedulesHandler()
        {
            _repo = new InquiryRepository();
        }


        /// <summary>
        /// Executes request asynchronously to get alternate name and address for obligor
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<GetPrincipalRepaySchedulesResponse> ExecuteAsync(GetPrincipalRepaySchedulesRequest request)
        {
            var principalRepaySchedules = await Task.Factory.StartNew(() =>
                _repo.GetPrincipalRepaymentSchedules(request));

            return principalRepaySchedules;
        }

    }
}
