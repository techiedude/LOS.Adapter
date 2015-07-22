using System.Threading.Tasks;
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Repository;

namespace LOS.Adapter.Data.Services.Handler
{
    /// <summary>
    /// CreateCollateralHandler
    /// </summary>
    public class CreateCollateralHandler : ICommandHandler<CreateCollateralCommand>
    {

        ICollateralRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollateralHandler"/> class.
        /// </summary>
        public CreateCollateralHandler()
        {
            _repo = new CollateralRepository();
        }


        /// <summary>
        /// Executes the CreateCollateral transaction as asynchronous task.
        /// </summary>
        /// <param name="command">CreateCollateralCommand command.</param>
        /// <returns></returns>
        public async Task ExecuteAsync(CreateCollateralCommand command)
        {
            await Task.Factory.StartNew(() =>
                 _repo.CreateCollateral(command));

        }
    }
}
