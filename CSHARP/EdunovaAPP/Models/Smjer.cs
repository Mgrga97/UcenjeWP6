using System.ComponentModel.DataAnnotations.Schema;

namespace EdunovaAPP.Models
{
    public class Smjer : Entitet
    {
        public string Naziv { get; set; } = "";
        [Column("Cijena")] // ovo je bit entity frameworka, mogucnost mapiranja
        public decimal? CijenaSmjera { get; set; }
        public DateTime IzvodiSeOd { get; set; }
        public bool Vaucer { get; set; }
    }
}
