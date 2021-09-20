using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointScript : MonoBehaviour
{
    public TextMeshProUGUI scoreShow;
    public Slider SyringeSlider;
    public GameObject OtherCharacter;
    public Animator anim;
    public GameObject Player;
    public int Score=0;
    public GameObject LosePanel;
    public ParticleSystem PartPlusTen;
    public ParticleSystem PartNegativeTen;
    public ParticleSystem PartPlusTwenty;
    public ParticleSystem PartNegativeTwenty;
    public AudioSource Plus;
    public AudioSource Transition;
    public GameObject BackGround;
    void Start()
    {
        PartPlusTen.Stop();
        PartNegativeTen.Stop();
        PartPlusTwenty.Stop();
        PartNegativeTwenty.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Score<0)
        {
            
            Player.GetComponent<Move>().enabled=false;
            scoreShow.color=Color.red;
            StartCoroutine(Lose());
        }
        else
        {
            anim.SetBool("Fall",false);
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag=="Medicine")
        {
            SyringeSlider.value+=10;
            Destroy(col.gameObject);
            Score +=10;
            scoreShow.text=" "+Score;
            PartPlusTen.Play();
            Plus.Play();
        }
        if (col.gameObject.tag=="NoVirus")
        {
            Score -=10;
            scoreShow.text=" "+Score;
            SyringeSlider.value-=10;
            PartNegativeTen.Play();
            Destroy(col.gameObject);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag=="Health")
        {
            SyringeSlider.value+=10;
            Score +=10;
            scoreShow.text=" "+Score;
            PartPlusTwenty.Play();
            Transition.Play();
        }
        if (col.gameObject.tag=="Danger")
        {
            SyringeSlider.value-=10;
            Score -=10;
            scoreShow.text=" "+Score;
            PartNegativeTwenty.Play();
            Transition.Play();
        }
    }
    IEnumerator Lose()
    {
        anim.SetBool("Fall",true);
        yield return new WaitForSeconds(3f);
        BackGround.SetActive(true);
        LosePanel.SetActive(true);
    }
}
