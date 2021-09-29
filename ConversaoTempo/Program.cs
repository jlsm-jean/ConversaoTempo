using System;

namespace ConversaoTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeInSeconds = int.Parse(Console.ReadLine());

            var hoursSeconds = 3600;
            var hours = timeInSeconds/ hoursSeconds;
            var minutes =  (timeInSeconds - (hoursSeconds * hours)) / 60;
            var seconds = ((timeInSeconds - (hoursSeconds * hours)) - (minutes * 60));

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
    }

