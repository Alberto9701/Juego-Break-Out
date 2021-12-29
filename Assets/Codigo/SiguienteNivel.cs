using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SiguienteNivel : MonoBehaviour
{
    public string NivelACargar;
    public int retraso;
    [ContextMenu("Activar Carga")]
    
    public void ActivarCarga()
    {
        Invoke("CargarNivel", retraso);
    }
    void CargarNivel()
    {
        if (!EsUltimoNivel())
        {
            Vidas.vidas++;
        }
        SceneManager.LoadScene(NivelACargar);
    }
    public bool EsUltimoNivel()
    {
        /*
        if (NivelACargar == "Portada")
        {
            return true;
        }
        else
        {
            return false;
        }
        */
        //esto devuelve lo mismo que el if
        // y el else de arriba
        return NivelACargar == "Portada";
    }
}
