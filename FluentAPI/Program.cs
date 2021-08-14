using System;

namespace FluentAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var house = BuildingYard
                .CreateHouse(config =>
                {
                    config.HouseName = "Green Mansion";
                })
                .AddMainHallway()
                .AddLivingRoom()
                .AddKitchen()
                .Build();
            Console.WriteLine(house);
        }
    }
}
