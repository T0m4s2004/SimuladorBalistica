using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamara : MonoBehaviour
{
    public GameObject Camara1;
    public GameObject Camara2;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bala")
        {
            Camara1.SetActive(false);
            Camara2.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Bala")
        {
            Camara1.SetActive(true);
            Camara2.SetActive(false);
        }
    }

    public void CambioCam()
    {
        Camara1.SetActive(true);
        Camara2.SetActive(false);
    }
}
