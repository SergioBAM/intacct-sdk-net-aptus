using Intacct.SDK.Xml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intacct.SDK.Functions.AccountsPayable
{
    public class VendorBankFileDetail : AbstractFunction
    {
        public string AccountCode;
        public string AccountName;
        public string AccountNumber;
        public string AccountType;
        public string BranchCode;
        public string BSBNumber;
        public string PaymentReference;
        public string ProofOfPaymentFlag;
        public string SortCode;
        public string RecordNumber;
        public string VendorId;
        public string VendorKey;
        public string CreditorBIC;

        public VendorBankFileDetail(string controlId = null) : base(controlId) 
        { 

        }

        public override void WriteXml(ref IaXmlWriter xml)
        {
            xml.WriteElement("ACCOUNTCODE", AccountCode);
            xml.WriteElement("ACCOUNTNAME", AccountName);
            xml.WriteElement("BANKACCOUNTNUMBER", AccountNumber);
            xml.WriteElement("ACCOUNTTYPE", AccountType);
            xml.WriteElement("BRANCHCODE", BranchCode);
            xml.WriteElement("BSBNUMBER", BSBNumber);
            xml.WriteElement("PYMTREFERENCE", PaymentReference);
            xml.WriteElement("PROOFOFPYMT", ProofOfPaymentFlag);
            xml.WriteElement("SORTCODE", SortCode);
            xml.WriteElement("RECORDNO", RecordNumber);
            xml.WriteElement("VENDORID", VendorId);
            xml.WriteElement("VENDORKEY", VendorKey);
            xml.WriteElement("BUSINESSIDCODE", CreditorBIC);
        }
    }
}
