using System.Collections.Generic;
namespace ParkingLotLib
{
    class Test
    {
        public static void Main(string[] args)
        {
            Lot lot = new Lot(1, 5);
            bool again = true;
            string vehicleNumber;
            string msg = "---------\nWelcome to parking lot\nPress 1 to Enter,\n2 to Exit,\n3 to see Available Spots,\nQ to quit\n---------\n";
            do
            {
                Console.WriteLine(msg);
                string input = Console.ReadLine();
                try
                {

                    switch (input)
                    {
                        case "1":
                            Console.Write("Enter vehicle number: ");
                            vehicleNumber = Console.ReadLine();
                            lot.Enter(vehicleNumber);
                            break;
                        case "2":
                            Console.Write("Enter vehicle number: ");
                            vehicleNumber = Console.ReadLine();
                            lot.Exit(vehicleNumber);
                            break;

                        case "3":
                            List<Spot> spots = lot.GetAvailableSpots();
                            Console.WriteLine("Available Spots: " + spots.Count);
                            break;

                        case "Q":
                        case "q":
                            again = false;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (again);

            Console.WriteLine("Bye!");
        }
    }

}