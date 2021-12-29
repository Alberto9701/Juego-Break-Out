using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public static int vidas = 3;
    public Text textoVidas;
    public Pelota pelota;
    public Barra barra;
    public GameObject gameover;
    public SiguienteNivel siguienteNivel;
    public SonidosFinPartida sonidosFinPartidas;

    
    // Start is called before the first frame update
    void Start()
    {
        ActualizarMarcadorDeVidas();
        
    }

    void ActualizarMarcadorDeVidas()
    {
        textoVidas.text = "Vidas: " + Vidas.vidas;
    }

    public void PerderVida()
    {
        if (Vidas.vidas <= 0)
        {
            return;
        }
        Vidas.vidas--;
        //aqui abajo tenemos codigo repetido
        //por lo que nos conviene mejor 
        //colocar este codigo en un metodo
        //text = "Vidas: " + Vidas.vidas;

        //aqui se hace lo mismo llamando a la funcion
        ActualizarMarcadorDeVidas();
        if (Vidas.vidas <= 0)
        {
            sonidosFinPartidas.GameOver();
            //mostramos game over
            gameover.SetActive(true);
            pelota.DetenerMovimiento();
            pelota.enabled = false;
            barra.enabled=false;
            siguienteNivel.NivelACargar = "Portada";
            siguienteNivel.ActivarCarga();
        }
        barra.Reset();
        pelota.Reset();

    }
}
