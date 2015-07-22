
using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services
{
    /// <summary>
    /// CreateCollateralCommand
    /// </summary>
    public class CreateCollateralCommand : BaseCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollateralCommand"/> class.
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
        public CreateCollateralCommand(string user, string password, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, password, luw, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, restartRequestCode)
        {

        }

        /// <summary>
        /// Gets or sets the type of the X1501_ function_type.
        /// </summary>
        /// <value>
        /// The type of the X1501_ functio n_.
        /// </value>
        public string x1501_FUNCTION_TYPE { get; set; }
        /// <summary>
        /// Gets or sets the X1501_ cusi p_ NBR.
        /// </summary>
        /// <value>
        /// The X1501_ cusi p_ NBR.
        /// </value>
        public string x1501_CUSIP_NBR { get; set; }
        /// <summary>
        /// Gets or sets the type of the X1501_ col l_.
        /// </summary>
        /// <value>
        /// The type of the X1501_ col l_.
        /// </value>
        public string x1501_COLL_TYPE { get; set; }
        /// <summary>
        /// Gets or sets the X1501_ advanc e_ PCT.
        /// </summary>
        /// <value>
        /// The X1501_ advanc e_ PCT.
        /// </value>
        public string x1501_ADVANCE_PCT { get; set; }
        /// <summary>
        /// Gets or sets the X1501_ re g_ u_ ad v_ PCT.
        /// </summary>
        /// <value>
        /// The X1501_ re g_ u_ ad v_ PCT.
        /// </value>
        public string x1501_REG_U_ADV_PCT { get; set; }
        /// <summary>
        /// Gets or sets the X1501_ nb r_ units.
        /// </summary>
        /// <value>
        /// The X1501_ nb r_ units.
        /// </value>
        public string x1501_NBR_UNITS { get; set; }
        /// <summary>
        /// Gets or sets the X1501_ uni t_ price.
        /// </summary>
        /// <value>
        /// The X1501_ uni t_ price.
        /// </value>
        public string x1501_UNIT_PRICE { get; set; }
        /// <summary>
        /// Gets or sets the X1501_ nb r_ pieces.
        /// </summary>
        /// <value>
        /// The X1501_ nb r_ pieces.
        /// </value>
        public string x1501_NBR_PIECES { get; set; }
        /// <summary>
        /// Gets or sets the X1501_ descriptio n1.
        /// </summary>
        /// <value>
        /// The X1501_ descriptio n1.
        /// </value>
        public string x1501_DESCRIPTION1 { get; set; }
        /// <summary>
        /// Gets or sets the X1501_ descriptio n2.
        /// </summary>
        /// <value>
        /// The X1501_ descriptio n2.
        /// </value>
        public string x1501_DESCRIPTION2 { get; set; }
        /// <summary>
        /// Gets or sets the X1501_ locatio n_ RCVD.
        /// </summary>
        /// <value>
        /// The X1501_ locatio n_ RCVD.
        /// </value>
        public string x1501_LOCATION_RCVD { get; set; }
        /// <summary>
        /// Gets or sets the X1501_ locatio n_ held.
        /// </summary>
        /// <value>
        /// The X1501_ locatio n_ held.
        /// </value>
        public string x1501_LOCATION_HELD { get; set; }
        /// <summary>
        /// Gets or sets the X1501_ ef f_ date.
        /// </summary>
        /// <value>
        /// The X1501_ ef f_ date.
        /// </value>
        public string x1501_EFF_DATE { get; set; }
        /// <summary>
        /// Gets or sets the X1501_ dat e_ RCVD.
        /// </summary>
        /// <value>
        /// The X1501_ dat e_ RCVD.
        /// </value>
        public string x1501_DATE_RCVD { get; set; }
        /// <summary>
        /// Gets or sets the X1501_ expir e_ date.
        /// </summary>
        /// <value>
        /// The X1501_ expir e_ date.
        /// </value>
        public string x1501_EXPIRE_DATE { get; set; }
        /// <summary>
        /// Gets or sets the X1501_ safekeepin g_ cd.
        /// </summary>
        /// <value>
        /// The X1501_ safekeepin g_ cd.
        /// </value>
        public string x1501_SAFEKEEPING_CD { get; set; }
        /// <summary>
        /// Gets or sets the X1501_ ma x_ length d_ value.
        /// </summary>
        /// <value>
        /// The X1501_ ma x_ length d_ value.
        /// </value>
        public string x1501_MAX_LEND_VALUE { get; set; }
        /// <summary>
        /// Gets or sets the X1501_ dd a_1.
        /// </summary>
        /// <value>
        /// The X1501_ dd a_1.
        /// </value>
        public string x1501_DDA_1 { get; set; }
        /// <summary>
        /// Gets or sets the X1508_ coupo n_ freq.
        /// </summary>
        /// <value>
        /// The X1508_ coupo n_ freq.
        /// </value>
        public string x1508_COUPON_FREQ { get; set; }
        /// <summary>
        /// Gets or sets the X1508_ nex t_ coupo n_ date.
        /// </summary>
        /// <value>
        /// The X1508_ nex t_ coupo n_ date.
        /// </value>
        public string x1508_NEXT_COUPON_DATE { get; set; }
        /// <summary>
        /// Gets or sets the X1508_ firs t_ coupo n_ amt.
        /// </summary>
        /// <value>
        /// The X1508_ firs t_ coupo n_ amt.
        /// </value>
        public string x1508_FIRST_COUPON_AMT { get; set; }
        /// <summary>
        /// Gets or sets the X1508_ regula r_ coupo n_ amt.
        /// </summary>
        /// <value>
        /// The X1508_ regula r_ coupo n_ amt.
        /// </value>
        public string x1508_REGULAR_COUPON_AMT { get; set; }
        /// <summary>
        /// Gets or sets the X1508_ geotra c_ NBR.
        /// </summary>
        /// <value>
        /// The X1508_ geotra c_ NBR.
        /// </value>
        public string x1508_GEOTRAC_NBR { get; set; }
        /// <summary>
        /// Gets or sets the X1508_ geotra c_ ind.
        /// </summary>
        /// <value>
        /// The X1508_ geotra c_ ind.
        /// </value>
        public string x1508_GEOTRAC_IND { get; set; }


    }
}
