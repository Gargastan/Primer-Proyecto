using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    public int vidas;
    public int bolívares;

    public string nombreJ1;

    public int numeroA;

    public int EXP;
    int LVL;

    public float radioCircunferencia;
    float PI = 3.14f;
    
    public float velocidadMedida;

    public float AlturaDelTriángulo;
    public float BaseDelTriángulo;


    // Start is called before the first frame update
    void Start()
    {
        //3.1
        Debug.Log("Hay " + vidas + " vidas y " + bolívares + " bolívares.");
        //3.2
        Debug.Log("Bienvenido de nuevo, " + nombreJ1 + ".");
        //3.3
        int numeroAx2 = numeroA * 2;
        Debug.Log("El doble del número introducido es " + numeroAx2 + ".");
        int numeroAx3 = numeroA * 3;
        Debug.Log("El triple del número introducido es " + numeroAx3 + ".");
        //3.4
        LVL = 32 + (9 * EXP / 5);
        Debug.Log("El nivel del personaje es " + LVL + ".");
        //3.5
        float perímetro = 2 * PI * radioCircunferencia;
        float área =( PI * radioCircunferencia)*(PI * radioCircunferencia);
        Debug.Log("El perímetro de visión es de " + perímetro + " metros. " + "El área de visión es de " + área + " metros cuadrados.");
        //3.6
        float metrosPorSegundo = (velocidadMedida * 1000/3600);
        Debug.Log("La velocidad medida es de " + metrosPorSegundo + " metros por segundo.");
        //3.7
        float áreaTriángulo = AlturaDelTriángulo * BaseDelTriángulo / 2;
        Debug.Log("El área de visión es de " + áreaTriángulo + " metros cuadrados.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
