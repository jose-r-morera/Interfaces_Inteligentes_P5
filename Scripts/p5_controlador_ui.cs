using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class p5_controlador_ui : MonoBehaviour
{
    public int puntuacion = 0;
    public TMP_Text texto_puntuacion;
    public string mensaje_puntuacion = "Puntuación: ";

    void Start()
    {
        p5_zombie.OnZombieMuerto += miRespuesta;
    }
    // Update is called once per frame
    void Update()
    {
    }
    void miRespuesta()
    {
        puntuacion += 5;
        texto_puntuacion.SetText(mensaje_puntuacion + puntuacion);
    }
}
