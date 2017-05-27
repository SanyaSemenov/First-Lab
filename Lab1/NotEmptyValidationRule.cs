using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Lab1
{
    public class NotEmptyValidationRule : ValidationRule
    {
        private const Int16 MAX = 1000;

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            Int16 i;
            try
            {
                i = Convert.ToInt16(value);
            }
            catch(Exception ex)
            {
                return new ValidationResult(false, "Пожалуйста, введите число");
            }

            if (i <= MAX)
                return new ValidationResult(true, String.Empty);
            else
            {
                MessageBox.Show("Введите число поменьше");
                return new ValidationResult(false, "Число превышает норму, проверьте и введите заново");
            }
        }
    }
}
