using System;

namespace Visitor
{
    public class Company: IBusinessEntity
	{
		private string name;

		public Company(string name)
		{
			this.name = name;
		}

		public string GetName()
		{
			return name;
		}

		public void DoBusiness()
		{
			Console.WriteLine("Non profit association \"" + name + "\" is doing business.");
		}

		public void CalculateBelgianTaxes()
		{
			Console.WriteLine("Calculated tax for business entity \"" + name + "\" using algorithm for Company based on the Belgian tax regulations.");
		}

		public void CalculateGermanTaxes()
		{
			Console.WriteLine("Calculated tax for business entity \"" + name + "\" using algorithm for Company based on the German tax regulations.");
		}
	}
}
