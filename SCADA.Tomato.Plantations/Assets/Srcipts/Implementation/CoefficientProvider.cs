namespace Assets.Srcipts.Implementation
{
    internal sealed class CoefficientProvider : ICoefficientProvider
    {
        private double value;

        public CoefficientProvider(double initValue)
        {
            this.value = initValue;
        }

        public double ChangeCoefficient(double newValue)
        {
            value = newValue;
            return value;
        }

        public double GetCoefficient()
        {
            return value;
        }
    }
}
