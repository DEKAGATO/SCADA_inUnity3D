using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniRx;

namespace Assets.Srcipts
{
    public sealed class TemperatureProvider
    {
        private BehaviorSubject<double> temperature;
        public double Temperature => temperature.Value;

        public TemperatureProvider(double initValue)
        {
            temperature = new BehaviorSubject<double>(initValue);
            Random random = new Random();

            Observable
                .Interval(TimeSpan.FromSeconds(1))
                .Subscribe(lowNum =>
                {
                    temperature.OnNext(temperature.Value + random.Next(-1, 2) * random.NextDouble() * 0.1);
                });
        }
    }
}
