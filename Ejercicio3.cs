using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    public int vidas;
    public int bol�vares;

    public string nombreJ1;

    public int numeroA;

    public int EXP;
    int LVL;

    public float radioCircunferencia;
    float PI = 3.14f;
    
    public float velocidadMedida;

    public float AlturaDelTri�ngulo;
    public float BaseDelTri�ngulo;


    // Start is called before the first frame update
    void Start()
    {
        //3.1
        Debug.Log("Hay " + vidas + " vidas y " + bol�vares + " bol�vares.");
        //3.2
        Debug.Log("Bienvenido de nuevo, " + nombreJ1 + ".");
        //3.3
        int numeroAx2 = numeroA * 2;
        Debug.Log("El doble del n�mero introducido es " + numeroAx2 + ".");
        int numeroAx3 = numeroA * 3;
        Debug.Log("El triple del n�mero introducido es " + numeroAx3 + ".");
        //3.4
        LVL = 32 + (9 * EXP / 5);
        Debug.Log("El nivel del personaje es " + LVL + ".");
        //3.5
        float per�metro = 2 * PI * radioCircunferencia;
        float �rea =( PI * radioCircunferencia)*(PI * radioCircunferencia);
        Debug.Log("El per�metro de visi�n es de " + per�metro + " metros. " + "El �rea de visi�n es de " + �rea + " metros cuadrados.");
        //3.6
        float metrosPorSegundo = (velocidadMedida * 1000/3600);
        Debug.Log("La velocidad medida es de " + metrosPorSegundo + " metros por segundo.");
        //3.7
        float �reaTri�ngulo = AlturaDelTri�ngulo * BaseDelTri�ngulo / 2;
        Debug.Log("El �rea de visi�n es de " + �reaTri�ngulo + " metros cuadrados.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
