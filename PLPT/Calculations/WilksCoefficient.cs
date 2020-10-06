using System;

namespace PLPT
{
    // Calculate wilks given correct values
    // REF:: https://en.wikipedia.org/wiki/Wilks_Coefficient
    public class WilksCoefficient
    {
        // Coefficient values to be used in male lifters
        private readonly double[] _maleCoef = new double[6] 
        {
        -216.0475144,
        16.2606339,
        -0.002388645,
        -0.00113732,
        7.01863E-06,
        -1.291E-08 
        };

        // Coefficient values to be used in female lifters
        private readonly double[] _femaleCoef = new double[6]
        {
        594.31747775582,
        -27.23842536447,
        0.82112226871,
        -0.00930733913,
        4.731582E-05,
        -9.054E-08
        };

        // Returns Wilks value given total weight lifted, bodyweight and gender
        public int CalculateCoefficient(int _total, int _bodyweight, bool _isMale)
        {
            return WilksCalculator(_bodyweight, _total, _isMale);
        }

        // Calculates Wilks | See REFF at top of page |
        private int WilksCalculator(int _bodyweight, int _total, bool _isMale)
        {
            double coeff = 0;

            // Decides which coefficient values to use based on gender
            var genderSpecificValues = _isMale == true ? _maleCoef : _femaleCoef;

            // Loops through the values against bodyweight to the power of i
            for (var i = 0; i <= 5; i++)
            {
                coeff += i == 0 ? genderSpecificValues[i] : (genderSpecificValues[i] * Math.Pow(_bodyweight, i));
            }

            // Divide final coefficient against 500 and multiply by total for final Wilks score
            var wilks = Int32.Parse(Math.Ceiling(_total * (500 / coeff)).ToString());

            return wilks;
        }
    }
}
