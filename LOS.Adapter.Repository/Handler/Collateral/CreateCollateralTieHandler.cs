using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Repository;
using System.Threading.Tasks;

namespace LOS.Adapter.Data.Services.Handler
{
    /// <summary>
    /// CreateCollateralTieHandler
    /// </summary>
    public class CreateCollateralTieHandler : ICommandHandler<CreateCollateralTieCommand>
    {

        ICollateralRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollateralTieHandler"/> class.
        /// </summary>
        public CreateCollateralTieHandler()
        {
            _repo = new CollateralRepository();
        }


        /// <summary>
        /// Executes the CreateCollateralTie transaction as asynchronous task.
        /// </summary>
        /// <param name="command">CreateCollateralTieCommand command.</param>
        /// <returns></returns>
        public async Task ExecuteAsync(CreateCollateralTieCommand command)
        {
            await Task.Factory.StartNew(() =>
                 _repo.CreateCollateralTie(command));

        }
    }
}
