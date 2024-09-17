using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Console;
using System.Globalization;

namespace WfaAbstrato
{
    internal class TrianguloIsosceles : Triangulo
    {
        private double baseT;
        private double altura;
        private double hipotenusa;

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
            hipotenusa = Math.Sqrt(Math.Pow(baseT / 2, 2) + Math.Pow(altura, 2));
            return Math.Round(baseT + 2 * hipotenusa, 2);
        }

        public override string ToString()
        {
            string BaseFormatado = baseT.ToString("F2", CultureInfo.InvariantCulture).Replace('.', ',');
            return $"Triângulo Isósceles({BaseFormatado})";

        }

    }
}
