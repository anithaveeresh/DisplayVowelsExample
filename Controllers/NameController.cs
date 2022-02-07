using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Display_Vowels.Controllers
{
    public class NameController : Controller
    {
        // GET: Name
        public ActionResult Index()
        {

            var tempName = new char[]{'a', 'n', 'i', 't','h','a'};
            var englishVowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            string vowelsInName = string.Empty;

            foreach (var letters in tempName)
            {
                if (englishVowels.Any(x => x == letters))
                {
                    vowelsInName = string.Format("{0}_{1}", vowelsInName, letters);
                }
            }

            ViewBag.VowelsInName = vowelsInName;
            return View();
        }
    }
}