using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotarX : MonoBehaviour
{
    public Text TexY;
    public Text TexX;
    public Slider EjeX;
    public float AnguloRotaci�n;
    public Slider EjeY;
    public float AnguloRotaci�nY;
    void Update()
    {
        AnguloRotaci�nY = EjeY.value * 1f;
        AnguloRotaci�n = EjeX.value * 1f;
        this.transform.rotation = Quaternion.Euler(AnguloRotaci�nY, AnguloRotaci�n, 0);
        TexX.text = "X: " + AnguloRotaci�n;
        TexY.text = "Y: " + AnguloRotaci�nY;
    }
}
