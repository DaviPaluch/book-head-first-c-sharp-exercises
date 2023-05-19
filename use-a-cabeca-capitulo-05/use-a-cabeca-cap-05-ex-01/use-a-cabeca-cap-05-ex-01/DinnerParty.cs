using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace use_a_cabeca_cap_05_ex_01
{
    internal class DinnerParty
    {
        const int CostOfFoodPerPerson = 25;
        private int NumberOfPeople;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;
        private bool fancyDecorations;
        

        public DinnerParty(int NumberOfPeople, bool healthlyOption, bool fancyDecorations)
        {
            this.NumberOfPeople = NumberOfPeople;
            this.fancyDecorations = fancyDecorations;
            SetHealthyOption(healthlyOption);
            CalculateCostOfDecorations(this.fancyDecorations);
        }

        public void SetNumberOfPeople(int NumberOfPeople)
        {
            this.NumberOfPeople = NumberOfPeople;
            CalculateCostOfDecorations(fancyDecorations);

        }
        public int GetNumberOfPeople()
        {
            return NumberOfPeople;
        }

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            } else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }

        public decimal CalculeCost(bool healthOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);

            if (healthOption)
            {
                return totalCost * .95M; //Aplica desconto de 5%
            }
            else
            {
                return totalCost;
            }
        }



    }
}
