using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    private float horizontal;
    //rango, para saber la rapides del jugador
    //rango para la velocidad
    [Range (1,10)]
    //velocidad
    public float velocidad;
    public GameObject Esfera;
    //constructor
    public Jugador()
    {
        this.velocidad = 2;
    }

    //crearemos un metodo
    void moverHorizontal()
    {
        //definir la tecla para el movimiento horizontal, de izq a der
        this.horizontal = Input.GetAxis("Horizontal");
        //Porque me movere en los 3 ejes -> Vector3
        transform.Translate(Vector3.right * (horizontal*Time.deltaTime*velocidad));

        if(transform.position.x < -4)
        {
            transform.position = new Vector3(x:-4, transform.position.y, transform.position.z);
        }
        if(transform.position.x > 4)
        {
            transform.position = new Vector3(x:4,transform.position.y, transform.position.z);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ejecuta los frames del movimiento, llamar al metodo que se ejecute
        moverHorizontal();
        lanzar();
    }


    //Metodo para lanzar
    void lanzar() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Esfera, transform.position, transform.rotation);
        }
    }

}
