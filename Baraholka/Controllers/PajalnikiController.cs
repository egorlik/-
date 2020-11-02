using Baraholka.Data.interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Baraholka.Controllers
{
    public class PajalnikiController : Controller
    {
        private readonly IAllPajalniki _allPajalniki;
        private readonly IpajalnikiCategory _allCategories;

        public PajalnikiController(IAllPajalniki iAllPajalniki, IpajalnikiCategory iPaJalnikiCat)
        {
            _allPajalniki = iAllPajalniki;
            _allCategories = iPaJalnikiCat;
        }
        public ViewResult List()
        {
            var pajalniki = _allPajalniki.Pajalniki;
            return View(pajalniki);
        }
    }
}
