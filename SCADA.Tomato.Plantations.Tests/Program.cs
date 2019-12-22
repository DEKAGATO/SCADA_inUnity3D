using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace SCADA.Tomato.Plantations.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var sensor = new BehaviorSubject<double>(0.00);

            Random random = new Random();

            Observable
                .Interval(TimeSpan.FromSeconds(1))
                .Subscribe(lowNum =>
                {
                    sensor.OnNext(random.NextDouble() * random.Next(-1, 2));
                    Console.WriteLine(sensor.Value);
                });


            Console.ReadKey();
        }

    }
}
