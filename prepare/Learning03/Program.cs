using System;

class Program
{
    static void Main(string[] args)
    {
       Fraction fraction1 = new Fraction();
       fraction1.DisplayFractionString();
       fraction1.DisplayDecimalValue();

       Fraction fraction2 = new Fraction(5);
       fraction2.DisplayFractionString();
       fraction2.DisplayDecimalValue();

       Fraction fraction3 = new Fraction(3,4);
       fraction3.DisplayFractionString();
       fraction3.DisplayDecimalValue();

       Fraction fraction4 = new Fraction(1,3);
       fraction4.DisplayFractionString();
       fraction4.DisplayDecimalValue();
    }
}