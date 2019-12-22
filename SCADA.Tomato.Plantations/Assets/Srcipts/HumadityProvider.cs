using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniRx;

namespace Assets.Srcipts
{
    public sealed class HumadityProvider
    {
        private BehaviorSubject<double> humadity;
        public double Humadity => humadity.Value;

        public HumadityProvider(double initValue)
        {
            humadity = new BehaviorSubject<double>(initValue);
            Random random = new Random();

            Observable
                .Interval(TimeSpan.FromSeconds(1))
                .Subscribe(lowNum =>
                {
                    humadity.OnNext(humadity.Value + random.Next(-1, 2) * random.NextDouble() * 0.1);
                });
        }
    }
}
