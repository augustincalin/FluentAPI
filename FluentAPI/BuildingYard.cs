using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
    public class BuildingYard: IHaveMainHallway, IHaveLivingRoom, IHaveKitchen, IBuild
    {
        private Room _bathRoom;
        private Room _kitchen;
        private Room _livingRoom;
        private Room _bedRoom;
        private Room _mainHallway;
        private HouseConfiguration _houseConfiguration;

        private BuildingYard(HouseConfiguration config) {
            _houseConfiguration = config;
        }

        public static IHaveMainHallway CreateHouse(Action<HouseConfiguration> config)
        {
            var configuration = new HouseConfiguration();
            config?.Invoke(configuration);
            return new BuildingYard(configuration);
        }

        public IBuild AddKitchen()
        {
            _kitchen = new Room();
            return this;

        }

        public IHaveKitchen AddLivingRoom()
        {
            _livingRoom = new Room();
            return this;
        }

        public IHaveLivingRoom AddMainHallway()
        {
            _mainHallway = new Room();
            return this;
        }

        public IHouse Build()
        {
            var house = new House(_houseConfiguration.HouseName, _mainHallway, _livingRoom, _kitchen);
            return house;
        }
    }
}
