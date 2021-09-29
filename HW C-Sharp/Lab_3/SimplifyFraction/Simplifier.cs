using System;

namespace Simplifier
{
    class Fraction
    {
        // с точки зрения организации класса лучше стараться не использовать открытые поля, а вместо них заводить свойства
        public int numerator;
        public int denominator;
        // почему бы вообще не отказаться от fractionAsString и просто переопределить метод ToString()? 
        public string fractionAsString;

        public Fraction(int num, int den)
        {
            numerator = num;
            denominator = den;
            // используйте лучше интерполяцию строк: 		
            fractionAsString = $"{numerator}/{denominator}";
        }

        public Fraction(string fr)
        {
            fractionAsString = fr;
            string[] subs = fr.Split('/');
            // теоретически subs[0] может оказаться невалидным числом 
            numerator = Convert.ToInt32(subs[0]);
            denominator = Convert.ToInt32(subs[1]);
        }
    }

    class SimplifierForFraction
    {
        public static string Simplify(string arg)
        {
            var frac = new Fraction(arg);
            var gcd = Gcd(frac.numerator, frac.denominator);
            var newFrac = new Fraction(frac.numerator / gcd, frac.denominator / gcd);
            return newFrac.fractionAsString;
        }

        private static int Gcd(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }
    }
}
