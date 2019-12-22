using Assets.Srcipts;
using UnityEngine;
using UnityEngine.UI;

namespace Assers.Scripts
{
    public class Temperature : MonoBehaviour
    {
        public double initValue;

        public Text Value;
        public Slider slider;
        private TemperatureProvider provider;

        void Start()
        {
            provider = new TemperatureProvider(initValue);
        }

        void Update()
        {
            Value.text = $"{provider.Temperature.ToString("00.00")}°C";
            slider.value = (float)provider.Temperature;
        }
    }
}
