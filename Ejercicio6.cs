using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour

{
    public int num = 1;
    int centena = 0;

    public int numA;
    public int numB;

    void Start()
    {
        //6.1
        while (centena < 100)
        {
            centena++;
            Debug.Log("N�mero " + centena + ".");
        }
        centena = 1;

        //6.2
        for (centena = 1; centena < 101; centena++)
        {
            Debug.Log("Numerito " + centena + ".");
        }
        centena = 101;

        //6.3
        while (centena > 1)
        {
            centena--;
            Debug.Log("N�mero " + centena + ".");
        }
        centena = 100;

        //6.4
        for (centena = 100; centena > 0; centena--)
        {
            Debug.Log("Numerito " + centena + ".");
        }
        centena = 100;

        //6.5
        int contador = 1;
        Debug.Log("Vamos a contar desde 1 hasta " + num + " .");
        while (contador < num)
        {
            Debug.Log(contador);
            contador++;
        }
        Debug.Log("Y por �ltimo, " + num + " .");

        //6.6
        contador = num;
        Debug.Log("Ahora, vamos a contar desde " + num + " hasta " + (-num) + " .");
        while (contador > (-num))
        {
            Debug.Log(contador);
            contador--;
        }
        Debug.Log("Y por �ltimo, " + (-num) + " .");

        //6.7
        if (numA > numB)
        {
            contador = numB;
            Debug.Log("A continuaci�n, vamos a contar desde " + numB + " hasta " + numA + " .");
            while (contador < numA)
            {
                Debug.Log(contador);
                contador++;
            }
            Debug.Log("Y por �ltimo, " + numA + " .");


        }
        else
        {
            if (numA < numB)
            {
                contador = numA;
                Debug.Log("A continuaci�n, vamos a contar desde " + numA + " hasta " + numB + " .");
                while (contador < numB)
                {
                    Debug.Log(contador);
                    contador++;
                }
                Debug.Log("Y por �ltimo, " + numB + " .");

            }

        }

        //6.8

        if (numA > numB)
        {
            Debug.Log("Vamos a ver los n�meros pares entre " + numB + " y " + numA + " .");
            contador = numB;
            while (contador < numA)
            {
                contador++;
                if (contador % 2 == 0)
                {
                    Debug.Log(contador);
                }

            }
        }
        else
        {
            if (numB > numA)
            {
                Debug.Log("Vamos a ver los n�meros pares entre " + numA + " y " + numB + " .");
                contador = numA;
                while (contador < numB)
                {
                    contador++;
                    if (contador % 2 == 0)
                    {
                        Debug.Log(contador);
                    }
                }
            }

        }

        //6.9
        Debug.Log("Vamos a ver los m�ltiplos de " + num + " .");
        contador = 1;
        while (contador < num)
        {
            contador++;
                 if (num % contador == 0)
            {
                Debug.Log(contador + " es m�ltiplo de " + num + " .");
            }
        }

        //6.10
        if (numA > numB)
        {
            Debug.Log("Vamos a ver los n�meros entre " + numB + " y " + numA + " .");
            contador = numB;
            while (contador < numA)
            {
                
                if (contador % 2 == 0)
                {

                    if (contador >= 0)
                    {
                        Debug.Log(contador + " es par y positivo.");
                    }
                    else
                    {
                        Debug.Log(contador + "  es par y negativo.");
                    }
                }
                else
                {
                    if (contador >= 0)
                    {
                        Debug.Log(contador + " es impar y positivo.");
                    }
                    else
                    {
                        Debug.Log(contador + " es impar y negativo.");
                    }
                }
                contador++;
            }




        }
        else
        {
            if (numB > numA)
            {
                Debug.Log("Vamos a ver los n�meros entre " + numA + " y " + numB + " .");
                contador = numA;
                while (contador < numB)
                {
                 
                    if (contador % 2 == 0)
                    {

                        if (contador >= 0)
                        {
                            Debug.Log(contador + " es par y positivo.");
                        }
                        else
                        {
                            Debug.Log(contador + "  es par y negativo.");
                        }
                    }
                    else
                    {
                        if (contador >= 0)
                        {
                            Debug.Log(contador + " es impar y positivo.");
                        }
                        else
                        {
                            Debug.Log(contador + " es impar y negativo.");
                        }
                    }
                    contador++;
                }
            }
        }

        //6.11
        Debug.Log("Vamos a ver la tabla de multiplicaci�n de " + num + " .");
        contador = 0;
            while (contador < 10)
        {
            contador++;
            Debug.Log(num + " por "+ contador + " = "+  num * contador);
        }
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
