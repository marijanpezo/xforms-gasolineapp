using GasolineApp.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GasolineApp.Data
{
    public class VehicleItemDatabase
    {
        static object locker = new object();

        SQLiteConnection database;

        public VehicleItemDatabase()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Vehicle>();
        }

        public IEnumerable<Vehicle> GetItems()
        {
            lock (locker)
            {
                return (from i in database.Table<Vehicle>() select i).ToList();
            }
        }


        public Vehicle GetItem(int id)
        {
            lock (locker)
            {
                return database.Table<Vehicle>().FirstOrDefault(x => x.Id == id);
            }
        }

        public int SaveItem(Vehicle item)
        {
            lock (locker)
            {
                if (item.Id != 0)
                {
                    database.Update(item);
                    return item.Id;
                }
                else
                {
                    return database.Insert(item);
                }
            }
        }

        public int DeleteItem(int id)
        {
            lock (locker)
            {
                return database.Delete<Vehicle>(id);
            }
        }
    }
}