using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cRegressiva : MonoBehaviour
{
    public GameObject contagemRegressiva3;
    public GameObject contagemRegressiva2;
    public GameObject contagemRegressiva1;
    public GameObject contagemRegressivaVa;
    public GameObject FadeIn;
    public AudioSource prepararFX;
    public AudioSource vaFX;

    void Start()
    {
        StartCoroutine(ContarSequencia());
    }

    IEnumerator ContarSequencia(){
        yield return new WaitForSeconds(1.5f);
        contagemRegressiva3.SetActive(true);
        prepararFX.Play();
        yield return new WaitForSeconds(1);
        contagemRegressiva2.SetActive(true);
        prepararFX.Play();
        yield return new WaitForSeconds(1);
        contagemRegressiva1.SetActive(true);
        prepararFX.Play();
        yield return new WaitForSeconds(1);
        contagemRegressivaVa.SetActive(true);
        vaFX.Play();
        jogMove.podeMover = true;
    }

}
