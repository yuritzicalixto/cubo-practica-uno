using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour
{
    private int limiteSuperior;
    private int limiteInferior;
    //Limite donde quiero que se destruya la esfera
    public Destructor(){
        this.limiteSuperior = 5;
        this.limiteInferior = -5;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Cuando la posición sea mayor al Limite Superior se destruye el objeto
    void Update()
    {
        if(transform.position.z > this.limiteSuperior)
        {
            Destroy(gameObject);
        }

        if(transform.position.z < this.limiteInferior)
        {
            Destroy(gameObject);
        }
    }
}
