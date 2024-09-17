using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaAbstrato
{
    public class TrianguloReto : Triangulo
    {
        private double baseT;
        private double altura;
        private double Cateto;
        private double CatetoO;
        private double hipo;

        public double Base
        {
            get { return baseT; }
            set { baseT = value; }
        }
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public override double CalcularArea()
        {
            return Math.Round((baseT * altura / 2), 2);

        }

        public override double CalcularPerimetro()
        {
            Cateto = Math.Pow(baseT, 2);
            CatetoO = Math.Pow(altura, 2);

            hipo = Math.Sqrt(Cateto + CatetoO);

            return Math.Round(baseT + altura + hipo, 2);
        }

        public override string ToString()
        {
            string BaseFormatado = baseT.ToString("F2", CultureInfo.InvariantCulture).Replace('.', ',');
            return $"Triângulo Reto({BaseFormatado})";

        }

    }
}
