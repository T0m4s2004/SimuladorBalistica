using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotarX : MonoBehaviour
{
    public Text TexY;
    public Text TexX;
    public Slider EjeX;
    public float AnguloRotación;
    public Slider EjeY;
    public float AnguloRotaciónY;
    void Update()
    {
        AnguloRotaciónY = EjeY.value * 1f;
        AnguloRotación = EjeX.value * 1f;
        this.transform.rotation = Quaternion.Euler(AnguloRotaciónY, AnguloRotación, 0);
        TexX.text = "X: " + AnguloRotación;
        TexY.text = "Y: " + AnguloRotaciónY;
    }
}
