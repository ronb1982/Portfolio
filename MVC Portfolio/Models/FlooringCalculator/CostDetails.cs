using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCPortfolio.Models.FlooringCalculator
{
    public class CostDetails
    {

        public int? SelectedId { get; set; }

        public Prices SelectedRate { get; set; }

        public Measurements Measurements { get; set; }
        public Prices Prices { get; set; }
        public CostsPerSqFoot CostsPerSqFoot { get; set; }

        public decimal TotalCosts { get; set; }

        public List<SelectListItem> Costs { get; set; }

        public CostDetails()
        {
            
        }

        public CostDetails(List<Prices> rates)
        {
            Costs = new List<SelectListItem>();

            foreach (var rate in rates)
            {
                Costs.Add(new SelectListItem()
                {
                    Text =string.Format("{0:c}", rate.Rate), Value = rate.Id.ToString()
                });
            }


        }

        public void CalculateTotalCosts(CostDetails model)
        {
            model.Measurements.Area = model.Measurements.Length * model.Measurements.Width;

            TotalCosts = model.Measurements.Area * model.Prices.Rate;
        }

        

    }
}