using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ValidationAttributes
{
	public class MustBeTrueValidationAttribute : ValidationAttribute
	{
		public override bool IsValid(object value)
		{
			return value is bool boolValue && boolValue;
		}
	}
}
