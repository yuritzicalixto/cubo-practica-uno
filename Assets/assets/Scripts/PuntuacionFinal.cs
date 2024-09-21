using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuntuacionFinal : MonoBehaviour
{
    public TMP_Text Puntuacion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Puntuacion.text = "Puntuación Final: " + juegoController.puntos.ToString() + " puntos";
    }
}
