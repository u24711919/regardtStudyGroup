using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace regardtStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult StudyGroupView()
        {
            List<Models.StudyGroupDetails> Members = new List<Models.StudyGroupDetails>();

            Members.Add(new Models.StudyGroupDetails { StudentNumber = "u24711919", Firstname = "Regardt", Surname = "van Heerden", EmailAddress = "u24711919@tuks.co.za" });
            Members.Add(new Models.StudyGroupDetails { StudentNumber = "u24664929", Firstname = "Arno", Surname = "Smalberger", EmailAddress = "u24664929@tuks.co.za" });
            Members.Add(new Models.StudyGroupDetails { StudentNumber = "u24592961", Firstname = "Le-Andri", Surname = "Viviers", EmailAddress = "u24592961@tuks.co.za" });
            Members.Add(new Models.StudyGroupDetails { StudentNumber = "u04581297", Firstname = "Tian", Surname = "Stoltz", EmailAddress = "u04581297@tuks.co.za" });
            Members.Add(new Models.StudyGroupDetails { StudentNumber = "u24612066", Firstname = "Eghardt", Surname = "du Tiot", EmailAddress = "u24612066@tuks.co.za" });
            return View(Members);
        }
    }
}