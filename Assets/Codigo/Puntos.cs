using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    public static int puntos = 0;
    public Text puntuacion;
    public GameObject nivelCompletado;
    public GameObject juegoCompletado;
    public Barra barra;
    public SiguienteNivel siguienteNivel;
    public Pelota pelota;
    public Transform contenedorBloques;
    public SonidosFinPartida sonidosFinPartida;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarPuntuacion();
    }
    void ActualizarPuntuacion()
    {
        puntuacion.text = "Puntos: " + Puntos.puntos; 
    }

    public void GanarPunto()
    {
        Puntos.puntos++;
        ActualizarPuntuacion();
        if (contenedorBloques.childCount <= 0)
        {
            pelota.DetenerMovimiento();
            pelota.enabled = false;
            barra.enabled = false;
            if (siguienteNivel.EsUltimoNivel() == true)
            {
                juegoCompletado.SetActive(true);
            }
            else
            {
                nivelCompletado.SetActive(true);
            }
            sonidosFinPartida.NivelCompletado();

            siguienteNivel.ActivarCarga();
            

        }
    }
}
