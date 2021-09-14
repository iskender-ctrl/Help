using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceOnVirus : MonoBehaviour
{
    private GameObject[] Viruses;
    public Animator anim;
    public float distance;
    void Start()
    {
        Viruses=GameObject.FindGameObjectsWithTag("Virus");
    }

    void Update()
    {
        Viruses=GameObject.FindGameObjectsWithTag("Virus");
        CloseVirus();
    }
    void CloseVirus()
    {
        foreach (GameObject v in Viruses)
        {
            distance = Vector3.Distance(transform.position,v.transform.position);
            if (v.activeInHierarchy==true)
            {
                if (distance<=6f)
                {
                    anim.SetBool("Throw",true);
                    gameObject.GetComponent<Move>().enabled=false;  

                    break;
                }
                else
                {
                    anim.SetBool("Throw",false);
                    gameObject.GetComponent<Move>().enabled=true;
                }
            }

        }
    }     
}
