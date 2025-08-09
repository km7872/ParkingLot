using System.Collections.Generic;
namespace ParkingLotLib
{
    public class Lot : ILotInterface
    {
        int lotNumber;
        List<Spot> spotsList;
        List<Spot> availableSpots;

        Dictionary<string, Spot> carMap;

        public Lot(int lotNumber, int size)
        {
            this.lotNumber = lotNumber;
            spotsList = new List<Spot>();
            carMap = new Dictionary<string, Spot>();
            availableSpots = new List<Spot>();

            for (int i = 0; i < size; i++)
            {
                Spot spot = new Spot(i + 1, lotNumber);
                spotsList.Add(spot);
                availableSpots.Add(spot);
            }
        }
        public List<Spot> GetAvailableSpots()
        {
            return availableSpots;
        }

        public void Enter(string licensePlate)
        {            
            if (availableSpots.Count > 0)
            {
                Spot item = availableSpots[availableSpots.Count - 1];
                item.SetOccupied(true);
                carMap[licensePlate] = item;
                availableSpots.RemoveAt(availableSpots.Count - 1);
            }
            throw new Exception("No available spots at this moment");
            
        }

        public void Exit(string licensePlate)
        {
            if (carMap.ContainsKey(licensePlate))
            {
                Spot item = carMap[licensePlate];

                item.SetOccupied(false);
                availableSpots.Add(item);
                carMap.Remove(licensePlate);
            }

            throw new Exception("Vehicle not found");
        }
    }
}