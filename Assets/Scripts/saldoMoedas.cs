using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class saldoMoedas : MonoBehaviour
{
   public static int contarMoeda;
   public GameObject painelContagem;
   public GameObject painelFinalContagem;

    void Update()
    {
        painelContagem.GetComponent<Text>().text = "" + contarMoeda;
        painelFinalContagem.GetComponent<Text>().text = "" + contarMoeda;
    }
}
