using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
    public class House : IHouse
    {
        public readonly string HouseName;
        private readonly Room _mainHallway;
        private readonly Room _bathRoom;
        private readonly Room _livingRoom;
        private readonly Room _kitchen;

        public House(string houseName, Room mainHallway, Room livingRoom, Room kitchen)
        {
            _mainHallway = mainHallway;
            _livingRoom = livingRoom;
            _kitchen = kitchen;
            HouseName = houseName;
        }

        public override string ToString()
        {
            return $"{HouseName} - LivingRoom: {_livingRoom is not null}; Kitchen: {_kitchen is not null}; Bathroom: {_bathRoom is not null}";
        }
    }
}
