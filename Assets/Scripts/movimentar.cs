using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentar : MonoBehaviour
{
   public static float esquerda = -3.5f;
   public static float direita = 3.5f;
   public float esquerdaInterna;
   public float direitaInterna;

    void Update()
    {
        esquerdaInterna = esquerda;
        direitaInterna = direita;
    }
}
