using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Srcipts
{
    public interface IData
    {
        char PlantationId { get; set; }
        double Temperature { get; set; }
        double Humadity { get; set; }
        DateTimeOffset SavingDate { get; set; }
    }
}
