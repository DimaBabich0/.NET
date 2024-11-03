using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW16
{
    internal class Program
    {
        static void Main()
        {
            do
            {
                try
                {
                    Console.WriteLine("Select a transport:");
                    Console.WriteLine("1. Car" +
                        "\n2. Train" +
                        "\n3. Horse" +
                        "\n4. Tanker ship" +
                        "\n5. Boat" +
                        "\n6. Motor ship" +
                        "\n7. Airplane" +
                        "\n8. Helicopter" +
                        "\n9. Airship"
                    );

                    string str = Console.ReadLine();

                    Transport transport = str switch
                    {
                        "1" => new Car(),
                        "2" => new Train(),
                        "3" => new Horse(),
                        "4" => new TankerShip(),
                        "5" => new Boat(),
                        "6" => new MotorShip(),
                        "7" => new Airplane(),
                        "8" => new Helicopter(),
                        "9" => new Airship(),
                        _ => throw new Exception("Option doesn't exist")
                    };


                    if (transport is GroundTransport groundTransport)
                    {
                        Console.WriteLine($"Ground transport type: {groundTransport.Name}");
                        groundTransport.Move();
                    }
                    else if (transport is WaterTransport waterTransport)
                    {
                        Console.WriteLine($"Water transport type: {waterTransport.Name}");
                        waterTransport.Move();
                    }
                    else if (transport is AirTransport airTransport)
                    {
                        Console.WriteLine($"Air transport type: {airTransport.Name}");
                        airTransport.Move();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                Console.WriteLine();
            } while (true);
        }
    }
}
