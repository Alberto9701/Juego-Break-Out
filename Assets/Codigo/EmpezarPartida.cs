using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmpezarPartida : MonoBehaviour
{
    //se crea una varible publica que colocaremos desde unity
    //en la escena de portada en el objeto de gestor del juego,
    //el validara si se esta pulsando el boron para empezar
    //la partida, ya sea el fire 1 o  su esta tocando la pantalla
    public ElementoInteractivo empezar;
    
    //usamos el update para validar en cada fotograma si se esta empezando la 
    //partida
    void Update()
    {
        //si se ha apretado el fire1 o si el objeto de texto
        //que hemos ampliado anteriormente se ha pulsado esto lo sabremos 
        //ya que el objeto llamado titulo contiene el script de 
        //elemento interactivo
        if (Input.GetButtonDown("Fire1") || empezar.pulsado==true)
        {
            //se reiniciara el contador de vidas
            //accediendo directamente a la varible vidas
            //de la clase Vidas
            Vidas.vidas = 3;
            //accedemos a la varible puntos de la clase
            //Puntos para reiniciarla
            Puntos.puntos = 0;
            //y finalmente se llamara para iniciar la escena
            //Nivel1
            SceneManager.LoadScene("Nivel1");
        }
    }
}
