using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceOnVirus : MonoBehaviour
{
    private GameObject[] Viruses;
    public Animator anim;
    public float distance;
    public GameObject ShotVirusGun;
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
                if (distance<=10f)
                {
                    anim.SetBool("Throw",true);
                    gameObject.GetComponent<Move>().enabled=false;  
                    ShotVirusGun.SetActive(true);
                }
                else
                {
                    anim.SetBool("Throw",false);
                    gameObject.GetComponent<Move>().enabled=true;
                    ShotVirusGun.SetActive(false);
                }
            }
            break;
        }
    }     
}
