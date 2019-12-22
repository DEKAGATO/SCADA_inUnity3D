using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniRx;

namespace Assets.Srcipts
{
    class TemperatureProvider
    {
        private BehaviorSubject<double> temperature;
        public UniRx.IObservable<double> Temperature => temperature;

        public TemperatureProvider()
        {
            temperature = new BehaviorSubject<double>(0.00);
            Random random = new Random();

            Observable
                .Interval(TimeSpan.FromSeconds(1))
                .Subscribe(lowNum =>
                {

                    temperature.OnNext(temperature.Value + random.NextDouble() * random.Next(-1, 2));
                });
        }
    }
}
