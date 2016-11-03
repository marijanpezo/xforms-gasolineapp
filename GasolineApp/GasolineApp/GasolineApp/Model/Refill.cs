using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasolineApp.Model
{
    public class Refill
    {
        public Refill() { }

        [PrimaryKey, AutoIncrement]
        public int Id { get; private set; }

        public DateTime Date { get; set; }

        public decimal Litres { get; set; }

        public long Mileages { get; set; }

        public decimal PricePerLitre { get; set; }

        public decimal Price { get; set; }

        public IList<Vehicle> Vehicles { get; set; }

    }
}
