using Assets.Srcipts;
using UnityEngine;
using UnityEngine.UI;

namespace Assers.Scripts
{
    public class HumaditySetter : MonoBehaviour
    {
        public double initValue;

        public Text Value;
        public Slider slider;
        private HumadityProvider provider;

        void Start()
        {
            provider = new HumadityProvider(initValue);
        }

        void Update()
        {
            Value.text = $"{provider.Humadity.ToString("00.00")}%";
            slider.value = (float)provider.Humadity;
        }
    }
}
