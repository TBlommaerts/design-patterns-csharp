using System;

namespace Visitor
{
    public class SoleTrader: IBusinessEntity
	{
		private string name;
	
		public SoleTrader(string name)
		{
			this.name = name;
		}

		public string GetName()
		{
			return name;
		}

		public void DoBusiness()
		{
			Console.WriteLine("Sole trader \"" + name + "\" is doing business.");
		}

		public void CalculateBelgianTaxes()
		{
			Console.WriteLine("Calculated tax for business entity \"" + name + "\" using algorithm for sole traders based on the Belgian tax regulations.");
		}

		public void CalculateGermanTaxes()
		{
			Console.WriteLine("Calculated tax for business entity \"" + name + "\" using algorithm for sole traders based on the German tax regulations.");
		}
	}
}
