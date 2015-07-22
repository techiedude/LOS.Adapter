using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Query;
using LOS.Adapter.Data.Services.Repository;
using System.Threading.Tasks;

namespace LOS.Adapter.Data.Services.Handler
{
    /// <summary>
    /// CreateAlternateNameAndAddressHandler
    /// </summary>
    public class CreateAlternateNameAndAddressHandler : ICommandHandler<CreateAlternateNameAndAddressCommand>
    {

        IObligorRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAlternateNameAndAddressHandler"/> class.
        /// </summary>
        public CreateAlternateNameAndAddressHandler()
        {
            _repo = new ObligorRepository();
        }


        /// <summary>
        /// Executes the CreateAlternateNameAndAddress transaction as asynchronous task.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns></returns>
        public async Task ExecuteAsync(CreateAlternateNameAndAddressCommand command)
        {
            await Task.Factory.StartNew(() =>
                 _repo.CreateAlternateNameAndAddress(command));

        }
    }
}
