using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18NasljedivanjePolimorfizam
{
    public class Smjer:Entitet  // klasa smjer naljeđuje svojstva iz klase entitet (public i protected)
    {

        public string Naziv { get; set; } = "";

        public override string ToString()
        {
            return Naziv;
        }


        public override bool Equals(object? obj)
        {
            return ((Smjer)obj).Naziv.Equals(Naziv);
        }

    }
}
