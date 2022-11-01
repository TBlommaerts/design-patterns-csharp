using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
		{
			IBusinessEntity soleTrader = new SoleTrader("Kruidenierszaak De Bolle");
			IBusinessEntity company = new Company("Volkswagen");
			IBusinessEntity nonProfit = new NonProfitAssociation("Greenpeace");

			IBusinessEntity[] businessEntities = new IBusinessEntity[] { soleTrader, company, nonProfit };

			foreach (IBusinessEntity businessEntity in businessEntities)
			{

				// Do your business
				businessEntity.DoBusiness();

				// Business is done: time for taxes
				businessEntity.CalculateBelgianTaxes();
				businessEntity.CalculateGermanTaxes();
			}
		}
    }
}
