
using LOS.Adapter.Data.Services.Query.Base;
using System.Collections.Generic;

namespace LOS.Adapter.Data.Services
{
    /// <summary>
    /// CreateCollateralTieCommand
    /// </summary>
    public class CreateCollateralTieCommand : BaseCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollateralTieCommand"/> class.
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
        public CreateCollateralTieCommand(string user, string password, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, password, luw, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, restartRequestCode)
        {

        }

        /// <summary>
        /// Gets or sets the request_ failed_ sw.
        /// </summary>
        /// <value>
        /// The request_ failed_ sw.
        /// </value>
        public string REQUEST_FAILED_SW { get; set; }
        /// <summary>
        /// Gets or sets the failing_ occurs_ number.
        /// </summary>
        /// <value>
        /// The failing_ occurs_ number.
        /// </value>
        public string FAILING_OCCURS_NUMBER { get; set; }
        /// <summary>
        /// Gets or sets the reques T_1192_ fields. 
        /// NOTE: [OCCURS 10 TIMES]
        /// </summary>
        /// <value>
        /// The request_1192_ fields.
        /// </value>
        public List<REQUEST_1192_FIELDS> FUTURE_SPECIFIC_ITEMS { get; set; }
        /// <summary>
        /// Gets or sets the reques T_1392_ fields.
        /// NOTE :[OCCURS 10 TIMES]
        /// </summary>
        /// <value>
        /// The request_1392_ fields.
        /// </value>
        public List<REQUEST_1392_FIELDS> CURRENT_SPECIFIC_ITEMS { get; set; }



    }

    /// <summary>
    /// REQUEST_1192_FIELDS
    /// </summary>
    public struct REQUEST_1192_FIELDS
    {

        public string x1192_SUPPORT_TYPE { get; set; }

        public string x1192_EFF_FROM_DATE { get; set; }

        public string x1192_SUPPORT_OBLIGOR { get; set; }

        public string x1192_SUPPORT_ITEM { get; set; }
    }
    /// <summary>
    /// REQUEST_1392_FIELDS
    /// </summary>
    public struct REQUEST_1392_FIELDS
    {

        public string x1392_SUPPORT_TYPE { get; set; }

        public string x1392_EFF_FROM_DATE { get; set; }

        public string x1392_SUPPORT_OBLIGOR { get; set; }

        public string x1392_SUPPORT_ITEM { get; set; }
    }

}
