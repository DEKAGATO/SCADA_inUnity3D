using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
public class CameraController : MonoBehaviour
{
    public Camera WholeCamera;
    public Camera CameraA;
    public Camera CameraB;
    public Camera CameraC;

    public Text textA;
    public Text textB;
    public Text textC;

    private List<Text> texts;

    void Start()
    {
        texts = new List<Text>() { textA, textB, textC };

        TurnToWholeCamera();
    }

    public void TurnToWholeCamera()
    {
        WholeCamera.enabled = true;

        CameraA.enabled = false;
        CameraB.enabled = false;
        CameraC.enabled = false;

        texts.ForEach(x => x.enabled = true);
    }

    public void TurnToCameraA()
    {
        CameraA.enabled = true;

        WholeCamera.enabled = false;
        CameraB.enabled = false;
        CameraC.enabled = false;

        texts.ForEach(x => x.enabled = false);
    }

    public void TurnToCameraB()
    {
        CameraB.enabled = true;

        WholeCamera.enabled = false;
        CameraA.enabled = false;
        CameraC.enabled = false;

        texts.ForEach(x => x.enabled = false);
    }

    public void TurnToCameraC()
    {
        CameraC.enabled = true;

        WholeCamera.enabled = false;
        CameraB.enabled = false;
        CameraA.enabled = false;

        texts.ForEach(x => x.enabled = false);
    }
}
