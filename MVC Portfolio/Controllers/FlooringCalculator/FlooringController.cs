using System.Linq;
using System.Web.Mvc;
using MVCPortfolio.Models.FlooringCalculator;

namespace MVCPortfolio.Controllers.FlooringCalculator
{
    public class FlooringController : Controller
    {
        //
        // GET: /Flooring/

        public ActionResult Index()
        {
            var rates = new CostsPerSqFoot();

            var model = new CostDetails(rates.RatesList);


            return View(model);
        }

        [HttpPost]
        public ActionResult Calculations(CostDetails model)
        {
            var rates = new CostsPerSqFoot();


            if (ModelState.IsValid)
            {
                model.SelectedRate = rates.RatesList.FirstOrDefault(s => s.Id == model.SelectedId);
                model.CalculateTotalCosts(model);
                return View(model);
            }


            else
                return View("Index", model);
        }

    }
}
