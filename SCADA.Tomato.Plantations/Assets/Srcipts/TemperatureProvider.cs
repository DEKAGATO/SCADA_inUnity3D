using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;

namespace Assets.Srcipts
{
    class TemperatureProvider
    {
        private BehaviorSubject<double> temperature;
        public IObservable<double> Temperature => temperature;

        public TemperatureProvider()
        {
            temperature = new BehaviorSubject<double>(0.00);

            temperature.Subscribe(f => Console.WriteLine($"Value is {f}"));// OnNext()
        }
    }

    public enum Temperature
    {
        Acceptble,
        Unacceptable
    }
}


