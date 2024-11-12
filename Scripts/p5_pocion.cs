using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p5_pocion : MonoBehaviour
{
    public p5_controlador_ui controlador_ui;

    public bool seguir = false;
    public float speed = 2.0f;
    GameObject jugador;
    Vector3 direccion_jugador;

    void Start()
    {
        controlador_ui.OnRecompensaPuntuacion += respuestaRecompensa;
        jugador = GameObject.FindWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {

        if (seguir)
        {
            direccion_jugador = jugador.transform.position - transform.position;
            transform.Translate(direccion_jugador.normalized * speed * Time.deltaTime, Space.World);
        }
    }

    void respuestaRecompensa()
    {
        seguir = true;
    }
}
