using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShotVirus : MonoBehaviour
{
    public GameObject Player;
    public ParticleSystem NegativeTwenty;
    public TextMeshProUGUI scoreShow;
    public Slider SyringeSlider;
    PointScript Scores;
    void Start()
    {
        Scores=GameObject.FindWithTag("Player").GetComponent<PointScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=Vector3.MoveTowards(transform.position,Player.transform.position,18*Time.deltaTime);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag=="Player")
        {
            Scores.Score -=20;
            scoreShow.text=" "+Scores.Score;
            SyringeSlider.value-=20;
            gameObject.SetActive(false);
            NegativeTwenty.Play();
            transform.localPosition=new Vector3(2.458519f,1.68f,-5.510002f);
        }
    }
}
