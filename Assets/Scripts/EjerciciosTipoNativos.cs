//Definir una función que escriba en consola “Hola Mundo!” al ser invocada.Invocar la función al presionar la barra espaciadora.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosTipoNativos : MonoBehaviour
{

    public float miFloat;
    public int n1, n2, n3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            HolaMundoEnLaConsola();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EscribirParemetroEnConsola("Hola Facu del futuro, hoy es 10/6/2022 a las 11:42, que tengas un buen dia");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            string num = ObtenerParteEnteraEnString(miFloat);

            EscribirParemetroEnConsola(num);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            EscribirParemetroEnConsola(DevolverMayor(n1, n2, n3).ToString());
        }


    }

    void HolaMundoEnLaConsola ()
    {
        Debug.Log("Hola Mundo!");
    }

    //Definir una función que escriba en consola la cadena pasada por parámetro.

    void EscribirParemetroEnConsola (string cadena)
    {
        Debug.Log(cadena);
    }

    //Recibe un float por parámetro y lo procesa para devolver la parte entera como un string.
    //Mostrar el dato devuelto en la consola utilizando la función del punto 1.2.

    string ObtenerParteEnteraEnString(float num)
    {
        string retorno = Mathf.Floor(num).ToString(); //Le saco la coma a el float. Me muestra solo el entero
        return retorno;
    }

    //Definir una función que reciba tres enteros y devuelva el mayor de ellos.Si son los tres iguales retornar -1.
    //Mostrar el dato devuelto en la consola utilizando la función del punto 1.2.


    int DevolverMayor (int num1, int num2, int num3)
    {
        int mayor = 0;

        if (num1 > num2 && num1 > num3)
        {
            mayor = num1;
        }

        if (num2 > num1 && num2 > num3)
        {
            mayor = num2;
        }

        if (num3 > num1 && num3 > num2)
        {
            mayor = num3;
        }

        else
        {
            mayor = -1;
        }

        return mayor;

    }

}
