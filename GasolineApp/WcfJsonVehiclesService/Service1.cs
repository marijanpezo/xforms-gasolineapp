using GasolineApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfJsonVehiclesService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private List<Vehicle> vehicles;

        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "data")]
        public List<Vehicle> GetData()
        {
            return vehicles = new List<Vehicle>
            {
                new Vehicle
                {
                    Id=1,
                    Name="Audi A6",
                    Fuel="Diesel",
                    Mileage= 116000
                },
                new Vehicle
                {
                    Id=2,
                    Name="Volvo s80",
                    Fuel="Diesel",
                    Mileage= 220000
                },
                new Vehicle
                {
                    Id=3,
                    Name="Polo A04",
                    Fuel="Diesel",
                    Mileage= 180000
                },
                new Vehicle
                {
                    Id=4,
                    Name="Volvo xc60",
                    Fuel="Diesel",
                    Mileage= 210000
                },
                new Vehicle
                {
                    Id=5,
                    Name="Passat B04",
                    Fuel="Diesel",
                    Mileage= 260000
                },

            };
        }

    }
}
