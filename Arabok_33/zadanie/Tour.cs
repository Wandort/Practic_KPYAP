using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie
{
    [Table("Туры")]
    public class Tour
    {
        [Column("Код_тура")]
        public int TourId { get; set; }
        [Column("Название")]
        public string Name { get; set; }
        [Column("Дата_начала")]
        public DateTime StartDate { get; set; }
        [Column("Дата_окончания")]
        public DateTime EndDate { get; set; }
        [Column("Цена")]
        public decimal Price { get; set; }
    }
}
