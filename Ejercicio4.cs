using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{
    public int nivel;

    public int vida1;
    public int vida2;

    public float numeroAComparar;

    public float dividendo;
    public float divisor;

    public float velocidadJ1;
    public float velocidadJ2;
    public float velocidadJ3;

    public int H;
    public int M;
    public int S;

    public float tipo;

    public float temperatura;
   
    // Start is called before the first frame update
    void Start()
    {
        //4.1
        if (nivel % 2 == 0)
        {
            Debug.Log("Tu nivel es par.");
        }
        else
        {
            Debug.Log("Tu nivel es impar.");
        }

        //4.2
        if (nivel % 10 == 0)
        {
            Debug.Log("¡Has aprendido un nuevo movimiento!");
        }
        else
         {
            Debug.Log("No has aprendido un nuevo movimiento...");
         }

        //4.3
        if (vida1 % vida2 == 0)
        {
            Debug.Log("¡La batalla está reñida!");
        }

        //4.4
        if (vida1<3 && vida2 < 3)
        {
            Debug.Log("¡Ambos personajes están a punto de morir!");
        }

        //4.5
        if(numeroAComparar>-1 && numeroAComparar < 10)
        {
            Debug.Log(numeroAComparar + " está entre 0 y 9.");
        }
        else
        {
            Debug.Log(numeroAComparar + " no está entre 0 y 9.");
        }

        //4.6
        if (divisor >0 ||divisor<0 )
        {
            Debug.Log("La división da " + (dividendo / divisor) + " .");
        }
        else
        {
            Debug.Log("No se puede operar con divisor 0.");
        }

        //4.7
        if(velocidadJ1>velocidadJ2 && velocidadJ1 > velocidadJ3)
        {
            Debug.Log("Jugador 1 ataca primero.");
        }
        else
        {
            if(velocidadJ2>velocidadJ1 && velocidadJ2 > velocidadJ3)
            {
                Debug.Log("Jugador 2 ataca primero.");
            }
            else
            {
                Debug.Log("Jugador 3 ataca primero.");
            }
        }

        //4.8
        if(H>-1 && H < 25)
        {
            if(M>-1 && M < 60)
            {
                if (S > -1 && S < 60)
                {
                    Debug.Log("Son las " + H + ":" + M + ":" + S + ".");
                }
                else
                {
                    Debug.Log("Formato horario inválido.");
                }
            }
        }

        //4.9
        if(tipo<1 || tipo>6 )
        {
            Debug.Log("Enemigo desconocido.");
        }
        else
        {
            if (tipo == 1)
            {
                Debug.Log("Enemigo con 350dmg & 650hp.");
            }
            else if (tipo == 2)
            {
                Debug.Log("Enemigo con 300dmg & 550hp.");
            }
            else if (tipo == 3)
            {
                Debug.Log("Enemigo con 300dmg & 500hp.");
            }
            else if (tipo == 4)
            {
                Debug.Log("Enemigo con 310dmg & 460hp.");
            }
            else if (tipo == 5)
            {
                Debug.Log("Enemigo con 280dmg & 490hp.");
            }
            else if (tipo == 6)
            {
                Debug.Log("Enemigo con 360dmg & 520hp.");
            }
        }

        //4.10
        if(temperatura <=9 )
        {
            Debug.Log("Clima frío.");
        }else if (10 < temperatura&& temperatura <= 20)
        {
            Debug.Log("Clima nublado.");
        }
        else if (20 < temperatura&& temperatura <= 30)
        {
            Debug.Log("Clima caluroso.");
        }
        else if (temperatura > 30)
        {
            Debug.Log("Clima tropical.");
        }
        
      
        
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
