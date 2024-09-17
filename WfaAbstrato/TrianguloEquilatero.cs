using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace WfaAbstrato
{
    internal class TrianguloEquilatero : Triangulo
    {
        private double baseT;

        public double Base
        {
            get { return baseT; }
            set { baseT = value; }
        }

        public override double CalcularArea()
        {
            return Math.Round((Math.Sqrt(3) / 4) * Math.Pow(baseT, 2), 2);

        }
        public override double CalcularPerimetro()
        {
            return Math.Round(3 * baseT, 2);
         
        }

        public override string ToString()
        {
            string BaseFormatado = baseT.ToString("F2", CultureInfo.InvariantCulture).Replace('.', ',');
            return $"Triângulo Equilátero({BaseFormatado})";

        }

    }
}
