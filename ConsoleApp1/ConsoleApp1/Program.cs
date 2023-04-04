using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Tartaly
    {

        private string name;
        private int a;
        private int b;
        private int c;
        private double aktLiter

        public Tartaly(string name, int a, int b, int c)
        {
            this.name = name;
            this.a = a;
            this.b = b;
            this.c = c;
            this.aktLiter = 0;
        }

        public Tartaly(String name)
        {
            this.name = name;
            this.a = 10;
            this.b = 10;
            this.c = 10;
        }

        public double Terfogat
        {
            get { return this.a * this.b * this.c; }
        }

        public void DuplazMeretet()
        {
            this.a *= 2;
        }
        
        public void TeljesLeengedes()
        {
            this.a = 0;
        }

        public double Toltottseg
        {
            get { return (this.aktLiter * 1000 / Terfogat) * 100; }
        }

        public void Tolt(double quantity)
        {

            if (Terfogat / 1000 < this.aktLiter + quantity)
            {
                throw new Exception("A megadott mennyiség már nem fér bele a tartályba");
            }
            this.aktLiter += quantity;
        }

        public string Info()
        {
            return $"{this.name}: {this.Terfogat:n1} cm3 = ({this.Terfogat / 1000:n2} liter)," +
                $" töltöttsége: {this.Toltottseg:n2}%, ({this.aktLiter:n2} liter)," +
                $" méretei: {this.a}x{this.b}x{this.c} cm";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Tartaly nagytartaly = new Tartaly("Nagytartály", 500, 200, 120);
            Tartaly literes = new Tartaly("Literes");
        }
    }
}
