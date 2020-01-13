using Assets;
using Assets.Srcipts;
using Assets.Srcipts.Implementation;
using System.Threading;
using System.Threading.Tasks;
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

        private ICoefficientProvider coefficientProvider;
        public InputField coefficientInputField;

        void Start()
        {
            provider = new HumadityProvider(initValue);

            coefficientProvider = new CoefficientProvider(double.Parse(coefficientInputField.text));
        }

        void Update()
        {
            Value.text = $"{provider.Humadity.ToString("00.00")}%";
            slider.value = (float)provider.Humadity;
        }

        public void Up()
        {
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(5000);

                var newValue = provider.Humadity + coefficientProvider.GetCoefficient();
                provider = new HumadityProvider(newValue);
            });
        }

        public void Down()
        {
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(5000);

                var newValue = provider.Humadity - coefficientProvider.GetCoefficient();
                provider = new HumadityProvider(newValue);
            });
        }
    }
}
