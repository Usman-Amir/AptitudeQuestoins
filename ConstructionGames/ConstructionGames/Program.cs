using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionGames
{
    public class Building
    {

        public List<string> listOfRooms = new List<string>();
        public string houseDesc;
        public Building()
        {

        }
        public Building AddKitchen()
        {
            listOfRooms.Add("kitchen");
            return this;
        }
        public Building AddBedroom(string bedroomType)
        {
            listOfRooms.Add(bedroomType + " room");
            return this;
        }
        public Building AddBalcony()
        {
            listOfRooms.Add("balcony");
            return this;
        }
    }
        class Program
    {
        private static void Main(string[] args)
        {
            var myHouse = new Building()
                .AddKitchen()
                .AddBedroom("master")
                .AddBedroom("guest")
                .AddBalcony();

            var normalHouse = myHouse.Build();

            //kitchen, master room, guest room, balcony
            Console.WriteLine(normalHouse.Describe());

            myHouse.AddKitchen().AddBedroom("another");

            var luxuryHouse = myHouse.Build();

            //it only shows the kitchen after build
            //kitchen, master room, guest room, balcony, kitchen, another room
            Console.WriteLine(luxuryHouse.Describe());
        }

    }
}
