using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculos : MonoBehaviour
{
    public GameObject jogador;
    public GameObject charModelo;
    public AudioSource colisao;
    public GameObject mainCam;
    public GameObject ControleMov;

    void OnTriggerEnter(Collider other){
        
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        jogador.GetComponent<jogMove>().enabled = false;
        charModelo.GetComponent<Animator>().Play("Stumble Backwards");
        ControleMov.GetComponent<cDistancia>().enabled = false;
        colisao.Play();
        mainCam.GetComponent<Animator>().enabled = true;
        ControleMov.GetComponent<gameOver>().enabled = true;
    }
    
}
