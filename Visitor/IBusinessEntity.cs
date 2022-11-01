using System;

namespace Visitor
{
	public interface IBusinessEntity
	{
		string GetName();

		void DoBusiness();

		// Bad separation of logic, implementations of this interface should not be responsible for this!
		void CalculateBelgianTaxes();
		void CalculateGermanTaxes();
	}	
}
