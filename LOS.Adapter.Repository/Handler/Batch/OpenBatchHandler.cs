using System.Threading.Tasks;
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Query;
using LOS.Adapter.Data.Services.Repository;

namespace LOS.Adapter.Data.Services.Handler
{
    /// <summary>
    /// OpenBatchHandler
    /// </summary>
    public class OpenBatchHandler : ICommandHandler<OpenBatchCommand>
    {

        IBatchRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenBatchHandler"/> class.
        /// </summary>
        public OpenBatchHandler()
        {
            _repo = new BatchRepository();
        }


        /// <summary>
        /// Executes the OpenBatch transaction as Asynchronous task.
        /// </summary>
        /// <param name="command">OpenBatchCommand command.</param>
        /// <returns></returns>
        public async Task ExecuteAsync(OpenBatchCommand command)
        {
            await Task.Factory.StartNew(() =>
                 _repo.OpenBatch(command));

        }
    }
}
