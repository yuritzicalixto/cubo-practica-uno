using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class juegoController : MonoBehaviour
{
    public static float tiempoJuego;
    public static int puntos;
    public static int vidas;
    private bool juegoActivo;
// Esto se refiere a los textos. Textos Text Mesh Pro.
    public TMP_Text txtVidas;
    public TMP_Text txtPuntos;
    public TMP_Text txtTiempo;
    // Start is called before the first frame update
    void Start()
    {
        puntos = 0; 
        vidas = 3;
        tiempoJuego= 30f; //30seg
        juegoActivo = true;  
    }

    // Update is called once per frame
    void Update()
    {
        //Validad cada metodo para funcionar
        if(juegoActivo)
            if(tiempoJuego > 0 )
            {
                tiempoJuego -= Time.deltaTime; 
                mostrarTiempo(tiempoJuego);
                mostrarDatos();
            } else 
            {
                tiempoJuego = 0;
                juegoActivo = false;
                SceneManager.LoadScene("victoria");
            }
        
    }

    void mostrarTiempo(float tiempo)
    {
        tiempo += 1;
        float minutos = Mathf.FloorToInt(tiempoJuego/60);
        float segundos = Mathf.FloorToInt(tiempoJuego%60);
        txtTiempo.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }
    //Mostrar los datos
    void mostrarDatos()
    {
        txtVidas.text = vidas.ToString()+ " Vidas";
        txtPuntos.text = puntos.ToString() + " Puntos";
    }
}
