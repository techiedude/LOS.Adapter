using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Repository;
using System.Threading.Tasks;

namespace LOS.Adapter.Data.Services.Handler
{
    /// <summary>
    /// CreateCurrentFeeScheduleHandler
    /// </summary>
    public class CreateCurrentFeeScheduleHandler : ICommandHandler<CreateCurrentFeeScheduleCommand>
    {

        IObligationRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCurrentFeeScheduleHandler"/> class.
        /// </summary>
        public CreateCurrentFeeScheduleHandler()
        {
            _repo = new ObligationRepository();
        }


        /// <summary>
        /// Executes the CreateCurrentFeeSchedule transaction as asynchronous task.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns></returns>
        public async Task ExecuteAsync(CreateCurrentFeeScheduleCommand command)
        {
            await Task.Factory.StartNew(() =>
                 _repo.CreateCurrentFeeSchedule(command));

        }
    }
}
