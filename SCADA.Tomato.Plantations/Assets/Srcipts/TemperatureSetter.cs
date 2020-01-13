using Assets;
using Assets.Srcipts;
using Assets.Srcipts.Implementation;
using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assers.Scripts
{
    public class TemperatureSetter : MonoBehaviour
    {
        public double initValue;

        public Text Value;
        public Slider slider;
        private TemperatureProvider provider;

        private ICoefficientProvider coefficientProvider;
        public InputField coefficientInputField;

        void Start()
        {
            provider = new TemperatureProvider(initValue);

            coefficientProvider = new CoefficientProvider(double.Parse(coefficientInputField.text));
        }

        void Update()
        {
            Value.text = $"{provider.Temperature.ToString("00.00")}%";
            slider.value = (float)provider.Temperature;
        }

        public void Up()
        {
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(5000);

                var newValue = provider.Temperature + coefficientProvider.GetCoefficient();
                provider = new TemperatureProvider(newValue);
            });
        }

        public void Down()
        {
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(5000);

                var newValue = provider.Temperature - coefficientProvider.GetCoefficient();
                provider = new TemperatureProvider(newValue);
            });
        }
    }
}
