using System.Collections.Generic;
namespace ParkingLotLib
{
    public interface ILotInterface
    {

        List<Spot> GetAvailableSpots();

        void Enter(string licensePlate);

        void Exit(string licensePlate);

    }
}