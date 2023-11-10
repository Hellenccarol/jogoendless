using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ambiente : MonoBehaviour
{
    public GameObject[] secao;
    public int zPosicao = 50;
    public bool criarSecao = false;
    public int secNum;
    
    void Update()
    {
        if(criarSecao == false){
            criarSecao = true;
            StartCoroutine(GerarSecao());
        }
    }

    IEnumerator GerarSecao(){
        secNum = Random.Range(0, 3);
        Instantiate(secao[secNum], new Vector3(0, 0, zPosicao), Quaternion.identity);
        zPosicao += 50;
        yield return new WaitForSeconds(5);
        criarSecao = false;
    }
}
