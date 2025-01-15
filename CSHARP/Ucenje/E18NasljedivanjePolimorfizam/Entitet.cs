using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18NasljedivanjePolimorfizam
{

    // apstraktna klasa je ona klasa koja ne može imati instancu
    // služi da sadržava zajed. svojstva i 
    public abstract class Entitet : Object 
    {

        public int Sifra { get; set; }

        public override string ToString()
        {
            return Sifra.ToString();
        }
    }
}
