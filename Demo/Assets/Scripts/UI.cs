using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UI : MonoBehaviour
{
    public GameObject WinPanel;
    public GameObject NoPerson;
    public GameObject BackGround;
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
        BackGround.SetActive(true);
        WinPanel.SetActive(true);
        Time.timeScale = 0.0f;
    }
}
