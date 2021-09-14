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
    public ParticleSystem VirusDestroyParticle1,VirusDestroyParticle2,VirusDestroyParticle3,VirusDestroyParticle4;
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
        VirusDestroyParticle2.Stop();
        VirusDestroyParticle3.Stop();
        VirusDestroyParticle4.Stop();
        PartPlusTen.Stop();
    }

    
    void Update()
    {
        transform.Translate(0,-15*Time.deltaTime,0);
        if (true)
        {
            
        }
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
            VirusDestroyParticle2.Play();
            VirusDestroyParticle3.Play();
            VirusDestroyParticle4.Play();
            PartPlusTen.Play();
            VirusDestroyVoice.Play();
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag=="Virus")
        {
            col.gameObject.tag="NoVirus";
            gameObject.SetActive(false);
            Player.GetComponent<Move>().enabled=true;
            anim.SetBool("Throw",false);
            HandMask.SetActive(true);
            transform.localPosition = new Vector3(0f,0f,0f);
        }
    }
}
