using System;
using System.Collections.Generic;
using System.Text;

namespace FractionApp
{
    public class Fraction   // класс
    {
        // поля
        private int chis;
        private int znam;


        //свойства
        public int Chis
        {
            get  
            { 
                return chis;
            }
            set 
            { 
                chis = value;
                Sokr();
            }
        }
        public int Znam
        {
            get
            {
                return znam;
            }
            set
            {
                if (value == 0)
                    throw new DivideByZeroException("знаменатель не может быть 0");
                znam = value;
                Sokr();
            }
        }
        //конструктор

        public Fraction(int c, int z)
        {
            Znam = z;
            Chis = c;
        }

        public Fraction() : this(0,1)
        {
        }
        //public Fraction()
        //{
        //    znam = 1;
        //}
        public Fraction(int c) : this(c, 1)
        {
        }
        //public Fraction(int c)
        //{
        //    Chis = c;
        //    Znam = 1;
        //}


        // методы

        private void Sokr()
        {
            if (chis * znam == 0)
                return;
            if(znam < 0)
            {
                chis = -chis;
                znam = -znam;
            }
            int a = Math.Abs(chis);
            int b = Math.Abs(znam);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            chis /= a;
            znam /= a;
        }

        public void ShowFrac()
        {
            Console.WriteLine($"{chis}/{znam}");
        }

        public void SetChisl(int c)
        {
            chis = c;
        }
       
        public void SetZnam(int z)
        {
            if (z == 0)
                throw new DivideByZeroException("знаменатель не может быть 0");
            znam = z;
        }
        public int GetChisl()
        {
            return chis;
        }
        public int GetZnam()
        {
            return znam;
        }

        public override string ToString()
        {
            if (Znam == 1)
                return $"{chis}";
            return $"{chis}/{znam}";
        }
    }



}
