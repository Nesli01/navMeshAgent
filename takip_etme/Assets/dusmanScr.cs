using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class dusmanScr : MonoBehaviour
{
    public NavMeshAgent dusman;
    public Transform oyuncu;
   
    void Update()
    {
        dusman.destination = oyuncu.position;

    }
}
