using MVC_BTR.Areas.BTR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BTR.Areas.BTR.Controllers
{
    public class BTRController : Controller
    {
        //
        // GET: /BTR/BTR/
        [HttpGet]
        public ActionResult Index()
        {
            BTopupRQ BTR = new BTopupRQ();

            List<SelectListItem> LstBranch = new List<SelectListItem>();
            LstBranch.Add(new SelectListItem { Text = "ALL", Value = "ALL" });
            LstBranch.Add(new SelectListItem { Text = "Chennai", Value = "21" });
            LstBranch.Add(new SelectListItem { Text = "Bangalore", Value = "30" });
            LstBranch.Add(new SelectListItem { Text = "Coimbatore", Value = "40" });
            BTR.ddlBranchName = LstBranch;

            List<SelectListItem> AgencyName = new List<SelectListItem>();
            AgencyName.Add(new SelectListItem { Text = "ALL", Value = "ALL" });
            AgencyName.Add(new SelectListItem { Text = "Mugesh International", Value = "RISXV0000001" });
            AgencyName.Add(new SelectListItem { Text = "Deepa Agency", Value = "RIMAA0000001" });
            BTR.ddlAgencyName = AgencyName;

            List<SelectListItem> AgentID = new List<SelectListItem>();
            AgentID.Add(new SelectListItem { Text = "ALL", Value = "ALL" });
            AgentID.Add(new SelectListItem { Text = "RISXV0000001", Value = "RISXV0000001" });
            AgentID.Add(new SelectListItem { Text = "RIMAA0000001", Value = "RIMAA0000001" });
            BTR.ddlAgentID = AgentID;


            return View(BTR);
        }

        [HttpPost]
        public ActionResult Index(BTopupRQ Input, string Submit)
        {
            BTopupRQ BTRP = new BTopupRQ();
            try
            {
                if (true)
                {
                    List<SelectListItem> LstBranch = new List<SelectListItem>();
                    LstBranch.Add(new SelectListItem { Text = "ALL", Value = "ALL" });
                    LstBranch.Add(new SelectListItem { Text = "Chennai", Value = "21" });
                    LstBranch.Add(new SelectListItem { Text = "Bangalore", Value = "30" });
                    LstBranch.Add(new SelectListItem { Text = "Coimbatore", Value = "40" });
                    BTRP.ddlBranchName = LstBranch;

                    List<SelectListItem> AgencyName = new List<SelectListItem>();
                    AgencyName.Add(new SelectListItem { Text = "ALL", Value = "ALL" });
                    AgencyName.Add(new SelectListItem { Text = "Mugesh International", Value = "RISXV0000001" });
                    AgencyName.Add(new SelectListItem { Text = "Deepa Agency", Value = "RIMAA0000001" });
                    BTRP.ddlAgencyName = AgencyName;

                    List<SelectListItem> AgentID = new List<SelectListItem>();
                    AgentID.Add(new SelectListItem { Text = "ALL", Value = "ALL" });
                    AgentID.Add(new SelectListItem { Text = "RISXV0000001", Value = "RISXV0000001" });
                    AgentID.Add(new SelectListItem { Text = "RIMAA0000001", Value = "RIMAA0000001" });
                    BTRP.ddlAgentID = AgentID;
                }
            }
            catch (Exception ex)
            {

            }
            return View(BTRP);
        }

    }
}
