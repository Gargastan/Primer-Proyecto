using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    int frames = 0;
    string userName = "Carlitos";
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Hola mundo");
        Debug.Log("Este es el primer videojuego de " + userName + ".");
        Debug.Log("Estoy aprendiendo a programar con ayuda de Elena");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ha pasado 1 frame.");
        frames = frames + 1;
        Debug.Log("este es el frame nº" + frames);
    }
}
//Este mensaje se actualiza cada frame.