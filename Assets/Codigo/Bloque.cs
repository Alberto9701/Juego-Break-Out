using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour
{
    //creamos una varible publica llamada particulas
    //la cual aparecera cuando la pelota colisione con
    //algun bloque
    public GameObject particulas;
    //creamos una varible publica que llevara la cuenta 
    //de cuantos puntos llevamos dependiendo de los bloques
    //con los que ha colisionado la pelota
    public Puntos puntos;

    //is trigger desactivado
    private void OnCollisionEnter(Collision collision)
    {
        //instanciamos en escena las particulas de esta manera
        Instantiate(particulas, transform.position,Quaternion.identity);
        //una vez que colisionamos con algun bloque, este se destruira
        Destroy(gameObject);
        //y aqui se desparenta de su objeto padre bloques
        //ya que el contador de hijos para que se valide que se 
        //acabo el nivel no contara al ultimo bloque
        //ya que la instruccion destroy se ejecuta hasta el ultima
        //frama, osea que va a ser la ultima instruccion en ejecutarse
        transform.SetParent(null);
        //y mandamos llamar al metodo GanarPunto de la clase puntos
        puntos.GanarPunto();

    }
    /*
     is trigger activado
    public void OnTriggerEnter(Collider other)
    {
        
    }

    */
}
