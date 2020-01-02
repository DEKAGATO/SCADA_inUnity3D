using System;

namespace Assets.Srcipts
{
    internal sealed class Data : IData
    {
        public char PlantationId { get; set; }
        public double Temperature { get; set; }
        public double Humadity { get; set;}
        public DateTimeOffset SavingDate { get; set; }

        public Data(char plantationId, double temperature, double humadity, DateTimeOffset savingDate)
        {
            this.PlantationId = plantationId;
            this.Temperature = temperature;
            this.Humadity = humadity;
            this.SavingDate = savingDate;
        }

    }
}
