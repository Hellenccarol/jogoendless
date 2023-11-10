using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public GameObject atualMoedas;
    public GameObject atualDist;
    public GameObject telaFim;
    public GameObject fadeOut;

    void Start()
    {
        StartCoroutine(terminaCorrida());
    }

    IEnumerator terminaCorrida(){
        yield return new WaitForSeconds(3);
        atualMoedas.SetActive(false);
        atualDist.SetActive(false);
        telaFim.SetActive(true);
        yield return new WaitForSeconds(3);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }

}
