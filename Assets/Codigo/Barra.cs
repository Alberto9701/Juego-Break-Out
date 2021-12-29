using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour
{
    //la velocidad con la que se movera la pelota
    public float velocidad = 0.4f;
    //guardamos la posicion inicial en una variable
    //para que cuando la pelota caiga al suelo se reinicie en
    //esta posicion
    Vector3 posicionInicial;
    /*
     * hacemos dos varibles de la clase ElementoInteractivo
     * una va a ser el boton izquierdo y el otro sera el boton derecho
     */
    public ElementoInteractivo botonIzquierda;
    public ElementoInteractivo botonDerecha;
    // Start is called before the first frame update
    void Start()
    {
        //se guarda el valor de la posicion inicial
        //una vez que el objeto aparece en la escena 
        //recordemos que es una varible de tipo vector 3
        posicionInicial = transform.position;
    }

    //creamos un metodo llamado reset que nos servira para 
    //indicar que pasará con la barra una vez que se reinicia
    //cuando la pelota cae al suelo
    public void Reset()
    {
        //en el metodo reset que creamos indicamos que se
        //regresara a la posicion inicial del objeto
        transform.position = posicionInicial;
    }

    // Update is called once per frame
    void Update()
    {
        /*
         esta es una forma de controlar los movimientos tactiles usando ifs

        float direccion;
        if (botonIzquierda.pulsado==true)
        {
            direccion = -1;
        }
        else if(botonDerecha.pulsado==true)
        {
            direccion = 1;
        }
        else
        {
            direccion = Input.GetAxisRaw("Horizontal");
        }
        */
        // y aqui esta una forma mas comprimida usando el simbolo ternario
        float direccion = botonIzquierda.pulsado ? -1 : (botonDerecha.pulsado ? 1 : Input.GetAxisRaw("Horizontal"));
        float posX = transform.position.x + (direccion*velocidad*Time.deltaTime);
        /*
         esta es una forma de delimitar la distancia de la barra con los ifs
        if (posX > 8)
            posX = 8;
        if (posX < -8)
            posX = -8;
        
        transform.position = new Vector3(posX, transform.position.y, transform.position.z);
        */
        //y esta es una forma de delimitarla con la funcion mathf.clamp(valor,el valor minimo que tendra,el valor maximo que tendra)
        transform.position = new Vector3(Mathf.Clamp(posX,-8,8), transform.position.y, transform.position.z);

    }
}
