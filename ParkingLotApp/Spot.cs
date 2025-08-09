
namespace ParkingLotLib
{
    public class Spot
    {
        int spotNumber;
        int lotNumber;

        bool occupied;

        public Spot(int spotNumber, int lotNumber)
        {
            this.spotNumber = spotNumber;
            this.lotNumber = lotNumber;
        }

        public void SetOccupied(bool occupied)
        {
            this.occupied = occupied;
        }

    }
    
}
