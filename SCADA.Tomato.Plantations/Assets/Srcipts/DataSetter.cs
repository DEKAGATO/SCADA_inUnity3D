using Assets.Srcipts;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class DataSetter : MonoBehaviour
{
    public char PlantationId;

    private TemperatureProvider temperatureProvider = new TemperatureProvider(0.00);
    private HumadityProvider humadityProvider = new HumadityProvider(0.00);
    private IData data;

    public Text LastSavingDate;

    public void Start()
    {
        temperatureProvider = new TemperatureProvider(0.00);
        humadityProvider = new HumadityProvider(0.00);

        LastSavingDate.text = "unknown";
    }
    public void SaveToFile()
    {
        var file = @"C:\Users\marta\Desktop\data.txt";

        if (Directory.Exists(file))
        {
            File.Create(file);
        }

        SetData();

        using (var writer = new StreamWriter(file, true))
        {
            string text = $"Plantation: {PlantationId}   |   Date: {data.SavingDate}   |   Temperature: {data.Temperature}   |   Humadity: {data.Humadity}";
            writer.WriteLine(text);
            writer.Close();
        }
    }

    private void SetData()
    {
        data = new Data(PlantationId, temperatureProvider.Temperature, humadityProvider.Humadity, DateTimeOffset.Now);
    }

    public void UpdateLastSavingDate()
    {
        LastSavingDate.text = data.SavingDate.ToString();
    }
}
