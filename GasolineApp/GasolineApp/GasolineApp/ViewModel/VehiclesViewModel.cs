using GasolineApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasolineApp.ViewModel
{
    public class VehiclesViewModel
    {

        public List<Vehicle> vehicles { get; }

        public VehiclesViewModel()
        {
            vehicles = new List<Vehicle>
        {
            new Vehicle
            {
                Id=1,
                Name="Audi A6",
                Fuel="Diesel",
                Mileage=116000
            },
            new Vehicle
            {
                Id=2,
                Name="Volvo s80",
                Fuel="Diesel",
                Mileage=220000
            },
            new Vehicle
            {
                Id=3,
                Name="Polo A04",
                Fuel="Diesel",
                Mileage=190000
            },
            new Vehicle
            {
                Id=4,
                Name="Volvo xc60",
                Fuel="Diesel",
                Mileage=200000
            },
            new Vehicle
            {
                Id=5,
                Name="Passat B4",
                Fuel="Diesel",
                Mileage=260000
            },
        };
        }
        
    }
}
