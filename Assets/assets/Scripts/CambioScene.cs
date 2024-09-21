using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Importar para cambiar de escena


public class CambioScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //creamos nuevo metodo
    public void escenaJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
