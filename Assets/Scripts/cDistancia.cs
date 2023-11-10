using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cDistancia : MonoBehaviour
{
    public GameObject painelDist;
    public GameObject painelFinalDist;
    public int contarDist;
    public bool addDis = false;
    public float distAtraso = 0.35f;

    void Update()
    {
        if(addDis == false){
            addDis = true;
            StartCoroutine(addDist());
        }
    }

    IEnumerator addDist(){
        contarDist += 1;
        painelDist.GetComponent<Text>().text = "" + contarDist;
        painelFinalDist.GetComponent<Text>().text = "" + contarDist;
        yield return new WaitForSeconds(distAtraso);
        addDis = false;
    }
}
