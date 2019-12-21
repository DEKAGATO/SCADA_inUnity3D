using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Timers;

namespace SCADA.Tomato.Plantation.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var sensor = new BehaviorSubject<double>(0.00);

            var oneNumberPerSecond = Observable.Interval(TimeSpan.FromSeconds(1));

            var lowNums = from n in oneNumberPerSecond
                          where n < 5
                          select n;

            oneNumberPerSecond.Subscribe(lowNum =>
            {
                sensor.OnNext(sensor.Value + 1);
                Console.WriteLine(sensor.Value);
            });


            Console.ReadKey();
        }

    }
}
