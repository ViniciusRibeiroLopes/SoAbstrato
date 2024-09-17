using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaAbstrato
{
    public class Retangulo : FormaGeometrica
    {
        private double baseT;

        public double Base
        {
            get { return baseT; }
            set { baseT = value; }
        }

        private double alt;

        public double Alt
        {
            get { return alt; }
            set { alt = value; }
        }

        public override double CalcularArea()
        {
            return Math.Round((baseT * alt), 2);

        }
        public override double CalcularPerimetro()
        {
            return Math.Round(((baseT * 2) + (alt * 2)), 2);

        }
        public override string ToString()
        {
            string BaseFormatado = baseT.ToString("F2", CultureInfo.InvariantCulture).Replace('.', ',');
            return $"Retângulo ({BaseFormatado})";

        }
    }
}
