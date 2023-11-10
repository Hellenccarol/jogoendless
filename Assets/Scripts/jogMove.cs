using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogMove : MonoBehaviour
{
    public float mVeloc = 5;
    public float esqdirVeloc = 4;
    static public bool podeMover = false;
    public bool pulando = false;
    public bool noChao = false;
    public GameObject jogadorObj;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * mVeloc, Space.World);
        if(podeMover == true){

            if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
                if (this.gameObject.transform.position.x > movimentar.esquerda){
                    transform.Translate(Vector3.left * Time.deltaTime * esqdirVeloc);
                }
            }

            if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
                if(this.gameObject.transform.position.x < movimentar.direita){
                    transform.Translate(Vector3.left * Time.deltaTime * esqdirVeloc * -1);
                }
            }

            if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space)){
                if(pulando == false){
                    pulando = true;
                    jogadorObj.GetComponent<Animator>().Play("Jump");
                    StartCoroutine(Pular());
                }
            }
        }

        if(pulando == true){
            if(noChao == false){
                transform.Translate(Vector3.up * Time.deltaTime * 3, Space.World);
            }
            if(noChao == true){
                transform.Translate(Vector3.up * Time.deltaTime * -3, Space.World);
            }
        }
    }

    IEnumerator Pular(){
        yield return new WaitForSeconds(0.45f);
        noChao = true;
        yield return new WaitForSeconds(0.45f);
        pulando = false;
        noChao = false;
        jogadorObj.GetComponent<Animator>().Play("Standard Run");
    }
}
