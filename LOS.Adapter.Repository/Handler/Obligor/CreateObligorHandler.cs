using System.Threading.Tasks;
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Repository;

namespace LOS.Adapter.Data.Services.Handler
{
    /// <summary>
    /// CreateObligorHandler
    /// </summary>
    public class CreateObligorHandler : ICommandHandler<CreateObligorCommand>
    {

        IObligorRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateObligorHandler"/> class.
        /// </summary>
        public CreateObligorHandler()
        {
            _repo = new ObligorRepository();
        }


        /// <summary>
        /// Executes the CreateObligor transaction as asynchronous task.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns></returns>
        public async Task ExecuteAsync(CreateObligorCommand command)
        {
            await Task.Factory.StartNew(() =>
                 _repo.CreateObligor(command));

        }
    }
}
