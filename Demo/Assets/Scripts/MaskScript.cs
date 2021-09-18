using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MaskScript : MonoBehaviour
{
    public TextMeshProUGUI scoreShow;
    public Slider SyringeSlider;
    public  GameObject HandMask;
    private GameObject[] Viruses;
    public GameObject Player;
    public ParticleSystem VirusDestroyParticle1;
    PointScript Scores;
    public float distance;
    public Animator anim;
    public ParticleSystem PartPlusTen;
    public AudioSource VirusDestroyVoice;

    void Awake()
    {
        VirusDestroyVoice.Stop();
    }
    void Start()
    {
        Viruses=GameObject.FindGameObjectsWithTag("Virus");
        Scores=GameObject.FindWithTag("Player").GetComponent<PointScript>();
        VirusDestroyParticle1.Stop();
        PartPlusTen.Stop();
    }

    
    void Update()
    {
        Attack();
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag=="Virus")
        {
            Scores.Score +=10;
            scoreShow.text=" "+Scores.Score;
            SyringeSlider.value+=10;
            Debug.Log("esdgdsg");
            transform.localPosition = new Vector3(0f,0f,0f);
            gameObject.SetActive(false);
            col.gameObject.SetActive(false);
            HandMask.SetActive(true);
            VirusDestroyParticle1.Play();
            PartPlusTen.Play();
            VirusDestroyVoice.Play();
        }
    }
    void Attack()
    {
        foreach (GameObject i in Viruses)
        {
            distance = Vector3.Distance(transform.position,i.transform.position);
            if (i.activeInHierarchy==true)
            {
                if (distance<=10f)
                {
                    transform.position=Vector3.MoveTowards(transform.position,i.transform.position,15*Time.deltaTime);
                }
            }
            break;
        }
    }
}
