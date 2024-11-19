using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai2024_11_19
{
    internal class Ber
    {
        public string nev { get; set; }
        public bool nem { get; set; }

        public string reszleg { get; set; }

        public int belepes { get; set; }
        public int ber { get; set; }


        public override string ToString()
        {
            return $"{nev} {(nem ? "férfi" : "nő")} {reszleg} {belepes} {ber}";
        }
        public Ber(string x)
        {
            string[] sor = x.Split(';');
            nev = sor[0];
            nem = sor[1] == "férfi";
            reszleg = sor[2];
            belepes = int.Parse(sor[3]);
            ber = int.Parse(sor[4]);

        }

    }
}
