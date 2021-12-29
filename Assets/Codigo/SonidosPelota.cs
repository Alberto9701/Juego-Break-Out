using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosPelota : MonoBehaviour
{
    public AudioSource punto;
    public AudioSource rebote;
    public void OnCollisionEnter(Collision otro)
    {
        if (otro.gameObject.CompareTag("Bloque")){
            punto.Play();
        }
        else
        {
            rebote.Play();
        }
    }
}
