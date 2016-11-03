using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasolineApp.Model
{
    public class Vehicle
    {
        public Vehicle() { }
        
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Fuel { get; set; }

        public double Mileage { get; set; }
    }
}
