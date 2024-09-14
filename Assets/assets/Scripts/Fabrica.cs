using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fabrica : MonoBehaviour
{
    public GameObject [] enemigos;
    private int randomEnemigo;
    private float rangoX=2;
    private float tiempo;

    void crearEnemigo()
    {
        //Genera de manera aleatoria a los enemigos
        //                                                            y       z
        Vector3 posicion = new Vector3(Random.Range(-rangoX, rangoX), 1.01f, 3.44f);
        //Selecciona los enemigos del arreglo
        randomEnemigo = Random.Range(0, enemigos.Length);
        Instantiate(enemigos[randomEnemigo], posicion, enemigos[randomEnemigo].transform.rotation);
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("crearEnemigo", 2,2); //Método que invoca a los 2 seg y lo repite cada 2seg
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
