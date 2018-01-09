using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_01_18app
{
    class Fraction
    {
        int numerator; // поля
        int denominator;
        public int Numerator //свойства
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value != 0) denominator = value;
                else
                {
                    Console.WriteLine("Некорректное значение знаменателя");
                    denominator = 1;
                }
            }
        }
        public Fraction() // конструктор без параметров
        {
            Numerator = 0;
            Denominator = 1;
        }
        public Fraction(int numerator, int denominator) // конструктор с параметрами
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public string Format()
        {
            if (denominator == 0 || numerator == 0)
            {
                return "0";
            }
            int absNum = Math.Abs(numerator);
            int absDenom = Math.Abs(denominator);

            string result = "";
            bool znak = Numerator < 0 || Denominator < 0;
            if (Numerator < 0 & Denominator < 0) znak = false;
            if (znak) result += "-";

            if (absNum < absDenom)
                result += absNum + "/" + absDenom;
            else if (absNum == absDenom)
                result += "1";
            else
            {
                int fr = absNum % absDenom;
                if (fr == 0)
                    result += absNum / absDenom;
                else
                    result += absNum / absDenom + " " + absNum % absDenom + "/" + absDenom;
            }
            return result;
        }

        public void Show() // метод для вывода дроби
        {
            Console.WriteLine(this.Format());
        }
        public Fraction Plus(Fraction f2)
        {
            Fraction result = new Fraction();
            if (Denominator == f2.Denominator)
            {
                result.Numerator = Numerator + f2.Numerator;
                result.Denominator = Denominator;
            }
            else
            {
                result.Numerator = Numerator * f2.Denominator + f2.Numerator * Denominator;
                result.Denominator = Denominator * f2.Denominator;
            }
            return result;
        }
    }
    class Program
    {
        static Fraction Plus(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();
            if (f1.Denominator == f2.Denominator)
            {
                result.Numerator = f1.Numerator + f2.Numerator;
                result.Denominator = f1.Denominator;
            }
            else
            {
                result.Numerator = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator;
                result.Denominator = f1.Denominator * f2.Denominator;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Fraction fract = new Fraction(5,1);
            fract.Show();
            Fraction fract_1 = new Fraction(1, 3);
            fract_1.Show();
            Fraction fract1 = new Fraction(3,4);
            fract1.Show();
            Fraction fract2 = new Fraction(5,5);
            fract2.Show();
            Fraction fract3 = new Fraction(0,5);
            fract3.Show();
            Fraction fract4 = new Fraction(5,5);
            fract4.Show();
            Fraction fract5 = new Fraction(-1,5);
            fract5.Show();
            Fraction fract6 = new Fraction(-1,-5);
            fract6.Show();
            Fraction fract7 = new Fraction(1,-5);
            fract7.Show();
            Fraction fract8 = new Fraction(1,0);
            fract8.Show();
            Fraction fract9 = new Fraction(0,0);
            fract9.Show();
            Fraction fract_plus = Plus(fract_1, fract1);
            fract_plus.Show();
            Fraction fract_plus_1 = fract_1.Plus(fract1);
            fract_plus_1.Show();
        }
    }

}
