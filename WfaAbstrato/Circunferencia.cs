using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WfaAbstrato
{
    internal class Circunferencia : FormaGeometrica
    {
        private double raio;

        public double Raio
        {
            get { return raio; }
            set { raio = value; }
        }

        public override double CalcularArea()
        {
            return Math.Round(Math.PI * Math.Pow(raio, 2), 2);
        }

        public override double CalcularPerimetro()
        {
            return Math.Round((Math.PI * (raio * 2) * 3), 2);
        }

        public override string ToString()
        {
            string BaseFormatado = raio.ToString("F2", CultureInfo.InvariantCulture).Replace('.', ',');
            return $"Circunferência ({BaseFormatado})";

        }
    }
}
