using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disparo : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject SpawnBala;
    public GameObject Bala;
    public float velocidad;
    public int CantidadBalas = 10;
    public Slider Velocidad;
    public Text VelocidadTex;
    public Text BalasText;
    public Button boton;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        boton = GetComponent<Button>();
    }

    public void Update()
    {
        velocidad = Velocidad.value * 1f;
        VelocidadTex.text = "Velocidad: " + velocidad;
        BalasText.text = "Balas: " + CantidadBalas;
        if (CantidadBalas == 0)
        {
            BalasText.gameObject.SetActive(true);
            Destroy(this);
        }
    }
    public void Disparar()
    {
        GameObject BalaTemporal = Instantiate(Bala, SpawnBala.transform.position, SpawnBala.transform.rotation) as GameObject;
        Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * velocidad);
        Destroy(BalaTemporal, 30f);
        CantidadBalas = CantidadBalas - 1;
    }

}
