using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services.Query
{
    /// <summary>
    /// OpenBatchCommand
    /// </summary>
    public class OpenBatchCommand : BaseCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenBatchCommand"/> class.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="password">The password.</param>
        public OpenBatchCommand(string user, string password)
            : base(user, password)
        {

        }


        /// <summary>
        /// Gets or sets the 0970_ collateral_ units.
        /// </summary>
        /// <value>
        /// The 0970_ collateral_ units.
        /// </value>
        public string x0970_COLLATERAL_UNITS { get; set; }
        /// <summary>
        /// Gets or sets the 0970_ credit_ total.
        /// </summary>
        /// <value>
        /// The 0970_ credit_ total.
        /// </value>
        public string x0970_CREDIT_TOTAL { get; set; }
        /// <summary>
        /// Gets or sets the 0970_ debit_ total.
        /// </summary>
        /// <value>
        /// The 0970_ debit_ total.
        /// </value>
        public string x0970_DEBIT_TOTAL { get; set; }
        /// <summary>
        /// Gets or sets the 0970_ entry_ date.
        /// </summary>
        /// <value>
        /// The 0970_ entry_ date.
        /// </value>
        public string x0970_ENTRY_DATE { get; set; }
        /// <summary>
        /// Gets or sets the 0970_ no_ of_ trans.
        /// </summary>
        /// <value>
        /// The 0970_ no_ of_ trans.
        /// </value>
        public string x0970_NO_OF_TRANS { get; set; }
        /// <summary>
        /// Gets or sets the 0970_ non_ gl_ total.
        /// </summary>
        /// <value>
        /// The 0970_ non_ gl_ total.
        /// </value>
        public string x0970_NON_GL_TOTAL { get; set; }
        /// <summary>
        /// Gets or sets the 0970_ origin_ unit.
        /// </summary>
        /// <value>
        /// The 0970_ origin_ unit.
        /// </value>
        public string x0970_ORIGIN_UNIT { get; set; }


    }
}
