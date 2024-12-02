using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{

    float caballeroAHP = 120;
    int caballeroAMaxHP = 120;
    float contadorVeneno = 0.03f;


    int edad = 0;
    int códigoPostal = 0;
    int altura = 0;
    bool género = false;
    string nombre = "User";
    int númeroDeHijos = 0;
    int iva = 0;
    int tallaCamisa = 0;
    int peso = 0;
    float precio = 0;
    bool alumnoRepetidor = false;
    string mensaje = "Null";
    char letra = 'a';
    bool mayorEdad = false;
    float minutos = 0;
    int días = 0;
    string matrículaCoche = "0000aaa";
    int contador = 0;
    string tallaCamiseta = "null";



    // Start is called before the first frame update
    void Start()
    {
        int vidas = 3;
        float exp = 2;
        char signo = 'M';

        Debug.Log("Vidas actuales: " + vidas);
        Debug.Log("Nivel de personaje: " + exp);

        float resultadoSuma = 0;
        float resultadoResta = 0;

        resultadoSuma = vidas + exp;
        resultadoResta = exp - vidas;
        Debug.Log("Resultado de la suma = "+ resultadoSuma);
        Debug.Log("Resultado de la resta = " + resultadoResta);

        float resultadoProducto = 0;
        float resultadoCociente = 0;
        float resultadoResto = 0;
        float dobleDeVidas = 0;
        float tripleDeExp = 0;
        resultadoProducto = vidas * exp;
        resultadoCociente = vidas / exp;
        resultadoResto = vidas % exp;      
        dobleDeVidas = vidas * 2;     
        tripleDeExp = exp * 3;

        vidas += 77;
        Debug.Log("Vidas actuales: " + vidas);
        vidas -= 3;
        Debug.Log("Vidas actuales: " + vidas);
        vidas *= 4;
        Debug.Log("Vidas actuales: " + vidas);

        int vidasPL1 = 1;
        int vidasPL2 = 4;
        int vidasPL3 = 7;
        int vidasPL4 = 9;

        int vidasIniciales1 = 1;
        int vidasIniciales2 = 4;
        int vidasiniciales3 = 7;
        int vidasiniciales4 = 9;

        vidasPL2 = vidasiniciales3;
        Debug.Log("Jugador 2 ahora tiene " + vidasPL2 + " vidas.");
        vidasPL3 = vidasIniciales1;
        Debug.Log("Jugador 3 ahora tiene " + vidasPL3 + " vidas.");
        vidasPL1 = vidasiniciales4;
        Debug.Log("Jugador 1 ahora tiene " + vidasPL1 + " vidas.");
        vidasPL4 = vidasIniciales2;
        Debug.Log("Jugador 4 ahora tiene " + vidasPL4 + " vidas.");


        int puntuación1 = 22;
        int puntuación2 = 47;
        int puntuación3 = 54;
        Debug.Log("Puntuación 1: " + puntuación1 + " puntos.");
        Debug.Log("Puntuación 2: " + puntuación2 + " puntos.");
        Debug.Log("Puntuación 3: " + puntuación3 + " puntos.");
        Debug.Log("Promedio: " + (puntuación1 + puntuación2 + puntuación3)/3 + " puntos.");

        int oro = 0;
        int oroPorSeg = 0;

        oroPorSeg = 7;
        Debug.Log("Oro por segundo: " + oroPorSeg + " uds.");
        int oroEsperadoEn4H = oro + (oroPorSeg * 60 * 60 * 4);
        Debug.Log("Oro esperado en 4h: " + oroEsperadoEn4H + " uds.");

       
        Debug.Log("Caballero tiene " +  120 + " puntos de vida.");
        Debug.Log("¡Caballero fue envenenado por Teemo!");
        StartCoroutine(Esperar());
       
    }

    IEnumerator Esperar()
    {

        while (caballeroAHP > 0)
        {
            yield return new WaitForSeconds(1);
            caballeroAHP -= (caballeroAMaxHP * contadorVeneno);
            if (caballeroAHP <= 0)
            {
             
                //StopCoroutine(Esperar());
            }
            else
            {
                contadorVeneno += 0.03f;
                Debug.Log("La vida del Caballero ha bajado a " + (caballeroAHP) + " puntos de vida.");

            }
        }
        Debug.Log("Caballero ha sido derrotado.");




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
