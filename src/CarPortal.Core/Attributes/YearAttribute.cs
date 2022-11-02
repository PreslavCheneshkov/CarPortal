using System.ComponentModel.DataAnnotations;

namespace CarPortal.Core.Attributes
{
    public class YearAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            bool result = false;

            if (int.TryParse(value?.ToString(), out int year))
            {
                if (year <= DateTime.UtcNow.Year)
                {
                    return true;
                }
            }

            return result;
        }
    }
}
