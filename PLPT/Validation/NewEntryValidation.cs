using System;
using System.Text.RegularExpressions;

namespace PLPT.Validation
{
    public class NewEntryValidation
    {
        #region Validates new entry data
        // Regex for integer matching
        private static readonly Regex regexNumericMatcher = new Regex(@"^\d+$");

        //Returns false if datetime greater than current date, or is more than 80 years ago
        public bool NewEntryDateChecker(DateTime date) => !(date > DateTime.Now || date < DateTime.Now.AddYears(-80));

        //Returns false if value is not numeric
        public bool NewEntryIntChecker(string value) => regexNumericMatcher.IsMatch(value);
        #endregion
    }
}