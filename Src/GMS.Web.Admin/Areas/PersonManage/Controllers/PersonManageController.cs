using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GMS.Account.Contract;
using GMS.Web.Admin.Common;
using GMS.Framework.Utility;
using GMS.Framework.Contract;

namespace GMS.Web.Admin.Areas.PersonManage
{
    public class PersonManageController : AdminControllerBase
    {
        //
        // GET: /PersonManage/PersonManage/

        public ActionResult Index()
        {
            return View();
        }

    }
}
