
using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services
{
    /// <summary>
    /// AssignObligationNumberCommand
    /// </summary>
    public class AssignObligationNumberCommand : BaseCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignObligationNumberCommand"/> class.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="password">The password.</param>
        /// <param name="bankId">The bank identifier.</param>
        /// <param name="obligorNumber">The obligor number.</param>
        /// <param name="batchid">The batchid.</param>
        /// <param name="obligationNumber">The obligation number.</param>
        /// <param name="segment">The segment.</param>
        /// <param name="restriction">The restriction.</param>
        /// <param name="dataLength">Length of the data.</param>
        /// <param name="itemNumber">The item number.</param>
        /// <param name="luw">The luw.</param>
        /// <param name="restartRequestCode">The restart request code.</param>
        public AssignObligationNumberCommand(string user, string password, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, password, luw, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, restartRequestCode)
        {

        }



    }
}
