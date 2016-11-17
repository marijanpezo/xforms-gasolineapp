using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using System.Collections;
using GasolineApp.Interfaces;
using GasolineApp.Model;

namespace GasolineApp.Data
{
    public class RefillDatabase
    {
        private readonly SQLiteConnection conn;

        public RefillDatabase()
        {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Vehicle>();
            conn.CreateTable<Refill>();
            
        }

        public IEnumerable<Refill> GetRefills()
        {
            var refills = (from refill in conn.Table<Refill>() select refill);
            return refills.ToList();
        }  
        public string AddRefill(Refill refill)
        {
            conn.Insert(refill);
            return "success";
        }

        public string DeleteRefill(int id)
        {
            conn.Delete<Refill>(id);
            return "success";
        }
    }
}