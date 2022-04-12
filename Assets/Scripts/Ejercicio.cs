using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio : MonoBehaviour {

    /*
     * 
El supermercado TicMarket nos pide que realicemos un programa para que sus clientes puedan calcular el costo de algunos productos que se encuentran en promoción

Se pide que se ingrese por inspector:
. Los nombre de tres productos
. Los precios de cada producto
. La cantidad de unidades deseada de cada producto

El programa debe cumplir los siguientes requerimientos:

Debe calcularse un descuento del 20% sobre la compra de un producto si la cantidad de unidades del mismo supera las 3. 

El programa debe devolver un mensaje de error descriptivo si el precio del producto o la cantidad de unidades son menores a 1.

El programa debe devolver el total de la compra de los tres productos mostrando un mensaje que incluya el monto total sin descuento, el monto de los descuentos aplicados y el total con los descuentos aplicados.

     */
    public string producto1;
    public string producto2;
    public string producto3;
    public int precio1;
    public int precio2;
    public int precio3;
    public int cantprod1;
    public int cantprod2;
    public int cantprod3;
    // Use this for initialization
    void Start () {
        int precioAdescontar1 = 0;
        int precioAdescontar2 = 0;
        int precioAdescontar3 = 0;
        // Solo se le aplica el descuento 1 vez a cada tipo de producto
        if (cantprod1 > 3)
        {
            precioAdescontar1 = precio1 * (20 / 100);
        }
        if (cantprod2 > 3)
        {
            precioAdescontar2 = precio2 * (20 / 100);
        }
        if (cantprod3 > 3)
        {
            precioAdescontar3 = precio3 * (20 / 100);
        }
        int valortot1 = (precio1 * cantprod1);
        int valortot2 = (precio2 * cantprod2);
        int valortot3 = (precio3 * cantprod3);
        int preciodescontado1 = precio1 - precioAdescontar1;
        int preciodescontado2 = precio2 - precioAdescontar2;
        int preciodescontado3 = precio3 - precioAdescontar3;
        int preciototal = valortot1 + valortot2 + valortot3;
        int precioTdesc = preciodescontado1 + preciodescontado2 + preciodescontado3;
        if (preciodescontado1 != 0 && preciodescontado2 != 0 && preciodescontado3 != 0) {
        precioTdesc = (preciototal - (precio1 + precio2 + precio3)) + (preciodescontado1 + preciodescontado2 + preciodescontado3);
        }
        else
        {
        }
        int descuentosTot = precioAdescontar1 + precioAdescontar2 + precioAdescontar3;

        if (precio1 >= 1 && precio2 >= 1 && precio3 >= 1 && cantprod1 >= 1 && cantprod2 >= 1 && cantprod3 >= 1)
        {
            Debug.Log("La cantidad total que tiene que pagar es "+ preciototal +", los descuentos aplicados son "+ descuentosTot + " y la cantidad total a pagar, con descuentos aplicados es "+precioTdesc);
        }
        if (precio1 < 1)
        {
            Debug.Log("ERROR: No puede tener un precio menor a 1");
        }
        if (precio2 < 1)
        {
            Debug.Log("ERROR: No puede tener un precio menor a 1");
        }
        if (precio3 < 1)
        {
            Debug.Log("ERROR: No puede tener un precio menor a 1");
        }
        if (cantprod1 < 1)
        {
            Debug.Log("ERROR: No puede tener una menor cantidad de productos que 1");
        }

        if (cantprod2 < 1)
        {
            Debug.Log("ERROR: No puede tener una menor cantidad de productos que 1");
        }

        if (cantprod3 < 1)
        {
            Debug.Log("ERROR: No puede tener una menor cantidad de productos que 1");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
