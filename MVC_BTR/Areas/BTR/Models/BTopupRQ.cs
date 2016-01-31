using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BTR.Areas.BTR.Models
{
    public class BTopupRQ
    {
        public List<SelectListItem> ddlBranchName { get; set; }
        public List<SelectListItem> ddlAgencyName { get; set; }
        public List<SelectListItem> ddlAgentID { get; set; }
        public string ddlAccountType { get; set; }
        public string ddlPaymentMode { get; set; }
        public string StrUserName { get; set; }
        public decimal StrAmount { get; set; }
        public string StrRemarks { get; set; }

        public string txtCashRequestedBy { get; set; }
        public string txtCashAmount { get; set; }
        public string txtCashRemarks { get; set; }
        public string txtChequeDate { get; set; }
        public string txtChequeN0 { get; set; }
        public string txtChequeBankName { get; set; }
        public string txtChequeBranchName { get; set; }
        public string txtChequeAmount { get; set; }
        public string txtChequeRemarks { get; set; }
        public string txtDDDdDate { get; set; }
        public string txtDDDdNo { get; set; }
        public string txtDDBankName { get; set; }
        public string txtDDBranchName { get; set; }
        public string txtDDAmount { get; set; }
        public string txtDDRemarks { get; set; }
        public string txtNetTransferID { get; set; }
        public string txtNetBankName { get; set; }
        public string txtNetAccNo { get; set; }
        public string txtNetAmount { get; set; }
        public string txtNetRemarks { get; set; }
    }
}