using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HarvestDate : MonoBehaviour
{
    public Text Value;
    void Start()
    {
        Value.text = "unknown";
    }

    public void UpdateHarvestDate()
    {
        Value.text = DateTimeOffset.Now.ToString();
    }
}
