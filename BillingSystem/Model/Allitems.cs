 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Model
{
    public class Allitems
    {
        public int SrNo { get; set; }
        public string ProductName { get; set; }
        public double Qantity { get; set; }
        public double Rate { get; set; }
        public double TotalAmount { get; set; }

        public string HsnCode { get; set; }
        public string CgstRate { get; set; }
        public string SgstRate { get; set; }
        public double CgstAmount { get; set; }
        public double SgstAmount { get; set; }


    }
}
