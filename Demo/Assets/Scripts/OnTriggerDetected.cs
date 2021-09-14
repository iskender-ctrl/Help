 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerDetected : MonoBehaviour
{
    public GameObject handMask;
    public GameObject prefabMask;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag=="Mask")
        {
            Debug.Log("bhjçg");
            handMask.SetActive(false);
            prefabMask.SetActive(true);
        }
    }
}
