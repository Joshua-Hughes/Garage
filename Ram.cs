using System;

namespace CustomColorsAndSounds
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }

        public override void Drive()
        {
            Console.WriteLine("The Dark Grey Ram trudges by! Brbrbrbrbrbrbroom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Ram very slowly turned {direction}, slinging mud everywhere!");
        }

        public override void Stop()
        {
            Console.WriteLine("The Ram finally came to a stop 10 minutes after hitting the brakes.");
        }
    }
}