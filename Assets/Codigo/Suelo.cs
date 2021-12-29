using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour
{
    public Vidas vidas;
    public AudioSource error;


    private void OnTriggerEnter(Collider other)
    {
        vidas.PerderVida();
        error.Play();


    }
}
