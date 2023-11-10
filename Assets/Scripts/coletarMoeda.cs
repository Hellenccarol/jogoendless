using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coletarMoeda : MonoBehaviour
{
    public AudioSource moedaFX;

    void OnTriggerEnter(Collider other){
        moedaFX.Play();
        saldoMoedas.contarMoeda += 1;
        this.gameObject.SetActive(false);
    }
}
