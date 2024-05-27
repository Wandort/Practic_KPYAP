using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie
{
    [Table("Туристы")]
    public class Tourist
    {
        [Column("Код_туриста")]
        public int TouristId { get; set; }
        [Column("Фамилия")]
        public string LastName { get; set; }
        [Column("Имя")]
        public string FirstName { get; set; }
        [Column("Отчество")]
        public string MiddleName { get; set; }
        [Column("Код_тура")]
        public int TourId { get; set; }
    }
}
