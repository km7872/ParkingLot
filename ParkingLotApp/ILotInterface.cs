using System.Collections.Generic;
namespace ParkingLotLib
{
    public interface ILotInterface
    {

        List<Spot> GetAvailableSpots();

        bool Enter(string licensePlate);

        bool Exit(string licensePlate);

    }
}