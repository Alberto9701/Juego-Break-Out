using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ElementoInteractivo : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    //creamos una variable buleana
    //para que valide si algun boton tactil ha sido pulsado
    //posteriormente se los colocaremos a los botones para
    //los controles tactiles
    public bool pulsado;

    //llamamos al metodo reservado OnPointerDown para que
    //valide si el objeto en el que esta puesto el script
    //esta siendo pulsado
    public void OnPointerDown(PointerEventData eventData)
    {
        //si esta siendo pulsado cambiamos el valor de la variable
        //a verdadero
        pulsado = true;
    }

    //llamamos al metodo reservado OnPointerDown en donde validara si 
    //al objeto en el que esta puesto el script NO esta siendo pulsado
    public void OnPointerUp(PointerEventData eventData)
    {
        //si no esta siendo pulsado cambiamos el valor de la
        //varible a falso
        pulsado = false;
    }
}
