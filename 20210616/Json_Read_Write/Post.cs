using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_Read_Write
{
    class Post
    {


        public Post(string resultcode, string resultmsg, string gOOD_CLSF, string gOOD_KOR_NM, string mAN1_ACC1_ITMS_YN, string cARD_ISUE_PSBL_YN, string iNTR_PAY_PSBL_YN, string iNTR_PAY_KIND, string eNTR_CUST_DVSN, string gOOD_TAXT_DVSN, string rEGISTER_MIN, string rEGISTER_MAX)
        {
            this.resultCode = resultcode;
            this.resultMsg = resultmsg;
            this.GOOD_CLSF = gOOD_CLSF;
            this.GOOD_KOR_NM = gOOD_KOR_NM;
            this.MAN1_ACC1_ITMS_YN = mAN1_ACC1_ITMS_YN;
            this.CARD_ISUE_PSBL_YN = cARD_ISUE_PSBL_YN;
            this.INTR_PAY_PSBL_YN = iNTR_PAY_PSBL_YN;
            this.INTR_PAY_KIND = iNTR_PAY_KIND;
            this.ENTR_CUST_DVSN = eNTR_CUST_DVSN;
            this.GOOD_TAXT_DVSN = gOOD_TAXT_DVSN;
            this.REGISTER_MIN = rEGISTER_MIN;
            this.REGISTER_MAX = rEGISTER_MAX;
        }

        public string resultCode { get; set; }
        public string resultMsg { get; set; }
        public string GOOD_CLSF { get; set; }
        public string GOOD_KOR_NM { get; set; }
        public string MAN1_ACC1_ITMS_YN { get; set; }
        public string CARD_ISUE_PSBL_YN { get; set; }
        public string INTR_PAY_PSBL_YN { get; set; }
        public string INTR_PAY_KIND { get; set; }
        public string ENTR_CUST_DVSN { get; set; }
        public string GOOD_TAXT_DVSN { get; set; }
        public string REGISTER_MIN { get; set; }
        public string REGISTER_MAX { get; set; }



    }
}
