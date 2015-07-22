
using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services
{
    /// <summary>
    /// L011 - Get Copybook
    /// </summary>
    public class CreateIndirectCommand : BaseCommand
    {
        public CreateIndirectCommand(string user, string password, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, password, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, luw, restartRequestCode)
        {

        }


        public REQUEST_1081_FIELDS[] REQUEST_1081_FIELDS { get; set; }
        public REQUEST_1191_FIELDS[] REQUEST_1191_FIELDS { get; set; }
        public REQUEST_1391_FIELDS[] REQUEST_1391_FIELDS { get; set; }


    }
    public struct REQUEST_1081_FIELDS
    {

        public short x1081_INDIRECT_TYPE;

        public int x1081_INDIRECT_EFFECT_DATE;

        public int x1081_INDIRECT_EXPIRE_DATE;

        public decimal x1081_INDIRECT_OBLIGOR;

        public string x1081_IND_AMOUNT_LIMIT;

        public string x1081_INDIRECT_GUAR_PCT;
    }
    public struct REQUEST_1191_FIELDS
    {

        public short x1191_INDIRECT_TYPE;

        public int x1191_INDIRECT_EFFECT_DATE;

        public int x1191_INDIRECT_EXPIRY_DATE;

        public decimal x1191_INDIRECT_OBLIGOR;

        public string x1191_INDIRECT_AMOUNT_LIMIT;

        public string x1191_INDIRECT_PERCENT_GUAR;

        public string x1191_IND_CR_BUR_ASSOC_CD;

        public string x1191_IND_PST_DU_E_NTC_OPT;
    }
    public struct REQUEST_1391_FIELDS
    {

        public short x1391_INDIRECT_TYPE;

        public int x1391_INDIRECT_EFFECT_DATE;

        public int x1391_INDIRECT_EXPIRY_DATE;

        public decimal x1391_INDIRECT_OBLIGOR;

        public string x1391_INDIRECT_AMOUNT_LIMIT;

        public string x1391_INDIRECT_PERCENT_GUAR;

        public string x1391_IND_CR_BUR_ASSOC_CD;

        public string x1391_IND_PST_DU_E_NTC_OPT;
    }

}
