using SQLite;
using System;

namespace GasolineApp.Model
{
    public class Refill
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; private set; }

        public DateTime Date { get; set; }

        public decimal Litres { get; set; }

        public double Mileages { get; set; }

        public decimal PricePerLitre { get; set; }

        public decimal Price { get; set; }

        public Vehicle Vehicle { get; set; }

        public Refill() { }

    }
}
