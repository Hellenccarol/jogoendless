using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotarObjs : MonoBehaviour
{
    public int rotarVeloc = 3;


    void Update()
    {
        transform.Rotate(0, rotarVeloc, 0, Space.World);
    }
}
