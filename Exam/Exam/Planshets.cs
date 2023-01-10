using System;
namespace Exam
{

    class Planshets
    {
        public Planshet[] PlanshetCollection { get; protected set; }

        public Planshets(params Planshet[] planshets)
        {
            PlanshetCollection = new Planshet[5];
            for (int i = 0; i < 5 && i < planshets.Length; i++)
            {
                PlanshetCollection[i] = planshets[i];
            }
        }

        public bool TryFindPlanshet(out Planshet result, string colorCollection = "", int year = 0, float price = 0, int battery = 0)
        {
            foreach (Planshet planshet in PlanshetCollection)
            {
                if (colorCollection != "")
                {
                    if (planshet.colorCollection != colorCollection) continue;
                }
                if (year != 0)
                {
                    if (planshet.year != year) continue;
                }
                if (price != 0)
                {
                    if (planshet.price != price) continue;
                }
                if (battery != 0)
                {
                    if (planshet.baterry != battery) continue;
                }

                result = planshet;
                return true;
            }
            result = default;
            return false;
        }
    }
}

