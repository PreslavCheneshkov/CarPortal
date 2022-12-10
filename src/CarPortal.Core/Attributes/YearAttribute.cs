using System.ComponentModel.DataAnnotations;

namespace CarPortal.Core.Attributes
{
    public class YearAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null)
            {
                return true;
            }

            bool result = false;

            if (int.TryParse(value?.ToString(), out int year))
            {
                if (year <= DateTime.UtcNow.Year)
                {
                    if (year >= 1900)
                    {
                        return true;
                    }
                    return false;
                }
            }

            return result;
        }
    }
}
