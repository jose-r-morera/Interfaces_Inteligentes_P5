using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p5_zombie : MonoBehaviour
{
    public delegate void mensaje();
    public static event mensaje OnZombieMuerto;

    public bool seguir = true;
    public float speed = 1.0f;
    GameObject jugador;
    Vector3 direccion_jugador;

    // Movimiento al morir
    float movement_minimum = 5.0f;
    float movement_maximum = 20.0f;

    void Start()
    {
        jugador = GameObject.FindWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(jugador.transform);

        if (seguir)
        {
            direccion_jugador = jugador.transform.position - transform.position;
            transform.Translate(direccion_jugador.normalized * speed * Time.deltaTime, Space.World);
        }
    }

    public void OnPointerEnter()
    {
        OnZombieMuerto();
        // Se mueve aleatoriamente en los ejes x y z
        transform.Translate(Random.Range(movement_minimum, movement_maximum), 0, Random.Range(movement_minimum, movement_maximum));
    }
    public void OnPointerExit()
    {
    }
}
