using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidom1
{
    internal class Kocka
    {
        double oldalA;

        public double OldalA
        {
            get => oldalA;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"{value} érték nem megengedett a kocka oldalának");
                }
                else
                {
                    oldalA = value;
                }
            }
        }

        public Kocka(double oldalA)
        {
            OldalA = oldalA;
        }
        public double Terulet()
        {
            return oldalA * oldalA;
        }
        public double Kerulet()
        {
            return 4 * oldalA;
        }
    }
}
