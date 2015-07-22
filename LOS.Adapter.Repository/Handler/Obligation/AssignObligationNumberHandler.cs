using System.Threading.Tasks;
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Repository;

namespace LOS.Adapter.Data.Services.Handler
{
    /// <summary>
    /// AssignObligationNumberHandler
    /// </summary>
    public class AssignObligationNumberHandler : ICommandHandler<AssignObligationNumberCommand>
    {

        IObligationRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignObligationNumberHandler"/> class.
        /// </summary>
        public AssignObligationNumberHandler()
        {
            _repo = new ObligationRepository();
        }


        /// <summary>
        /// Executes the AssignObligationNumber transaction as asynchronous task.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns></returns>
        public async Task ExecuteAsync(AssignObligationNumberCommand command)
        {
            await Task.Factory.StartNew(() =>
                 _repo.AssignObligationNumber(command));

        }
    }
}
