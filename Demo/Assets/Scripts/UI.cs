using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UI : MonoBehaviour
{
    public GameObject WinPanel;
    public GameObject NoPerson;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (NoPerson.activeInHierarchy==false)
        {
            StartCoroutine(ExampleCoroutine());
        }
    }
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(4f);
        WinPanel.SetActive(true);
        Time.timeScale = 0.0f;
    }
}
