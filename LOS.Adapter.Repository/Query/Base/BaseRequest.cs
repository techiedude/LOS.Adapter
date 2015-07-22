
using LOS.Adapter.CQS;

namespace LOS.Adapter.Data.Services.Query.Base
{
    /// <summary>
    /// Base Request class for Requests
    /// </summary>
    /// <typeparam name="TReply">The type of the reply.</typeparam>
    public abstract class BaseRequest<TReply> : Request<TReply>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRequest{TReply}"/> class.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="password">The password.</param>
        public BaseRequest(string user, string password)
        {
            User = user;
            Password = password;
            HeaderRestrictions = Constants.LUW_HEADER_RESTRICTIONS;
            Errors = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRequest{TReply}"/> class.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="password">The password.</param>
        /// <param name="luw">The luw.</param>
        /// <param name="bankId">The bank identifier.</param>
        /// <param name="obligorNumber">The obligor number.</param>
        /// <param name="batchId">The batch identifier.</param>
        /// <param name="obligationNumber">The obligation number.</param>
        /// <param name="segment">The segment.</param>
        /// <param name="headerRestrictions">The header restrictions.</param>
        /// <param name="dataLength">Length of the data.</param>
        /// <param name="itemNumber">The item number.</param>
        /// <param name="restartCode">The restart code.</param>
        public BaseRequest(string user, string password, string luw, string bankId, string obligorNumber, string batchId, string obligationNumber, string segment, string headerRestrictions, string dataLength, string itemNumber, string restartCode)
            : this(user, password)
        {
            BankId = bankId;
            ObligorNumber = obligorNumber;
            BatchID = batchId;
            ObligationNumber = obligationNumber;
            Segment = segment;
            HeaderRestrictions = Constants.LUW_HEADER_RESTRICTIONS;//headerRestrictions;
            DataLength = dataLength;
            ItemNumber = itemNumber;
            Luw = luw;
            RestartRequestCode = restartCode;
        }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        public string User { get; set; }
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get; set; }
        /// <summary>
        /// Gets or sets the errors.
        /// </summary>
        /// <value>
        /// The errors.
        /// </value>
        public string Errors { get; set; }

        /// <summary>
        /// Gets or sets the bank identifier.
        /// </summary>
        /// <value>
        /// The bank identifier.
        /// </value>
        public string BankId { get; set; }
        /// <summary>
        /// Gets or sets the obligor number.
        /// </summary>
        /// <value>
        /// The obligor number.
        /// </value>
        public string ObligorNumber { get; set; }
        /// <summary>
        /// Gets or sets the batch identifier.
        /// </summary>
        /// <value>
        /// The batch identifier.
        /// </value>
        public string BatchID { get; set; }
        /// <summary>
        /// Gets or sets the obligation number.
        /// </summary>
        /// <value>
        /// The obligation number.
        /// </value>
        public string ObligationNumber { get; set; }
        /// <summary>
        /// Gets or sets the segment.
        /// </summary>
        /// <value>
        /// The segment.
        /// </value>
        public string Segment { get; set; }
        /// <summary>
        /// Gets or sets the header restrictions.
        /// </summary>
        /// <value>
        /// The header restrictions.
        /// </value>
        public string HeaderRestrictions { get; set; }
        /// <summary>
        /// Gets or sets the length of the data.
        /// </summary>
        /// <value>
        /// The length of the data.
        /// </value>
        public string DataLength { get; set; }
        /// <summary>
        /// Gets or sets the item number.
        /// </summary>
        /// <value>
        /// The item number.
        /// </value>
        public string ItemNumber { get; set; }
        /// <summary>
        /// Gets or sets the luw.
        /// </summary>
        /// <value>
        /// The luw.
        /// </value>
        public string Luw { get; set; }
        /// <summary>
        /// Gets or sets the restart request code.
        /// </summary>
        /// <value>
        /// The restart request code.
        /// </value>
        public string RestartRequestCode { get; set; }
    }


    /// <summary>
    /// BaseResponse
    /// </summary>
    public abstract class BaseResponse
    {
        /// <summary>
        /// Gets or sets the errors.
        /// </summary>
        /// <value>
        /// The errors.
        /// </value>
        public string Errors { get; set; }
    }
}
