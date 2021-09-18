using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalEtap : MonoBehaviour
{
    PointScript Syringe;
    public GameObject Character1,Character2,Character3;
    public GameObject FalseCharacter1,FalseCharacter2,FalseCharacter3;
    public GameObject OtherCharacter;
    public GameObject cam;
    public GameObject cam2;
    public GameObject UI;
    public TextMeshProUGUI TotalScoresTxt;
    public Animator anim;
    public GameObject NoPerson;
    void Start()
    {
        Syringe=GameObject.FindWithTag("Player").GetComponent<PointScript>();

    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name=="FinalEtap")
        {
            gameObject.SetActive(false);
            OtherCharacter.SetActive(true);
            if (Syringe.SyringeSlider.value<20)
            {
                anim.SetBool("Sad",true);
                NoPerson.SetActive(true);
            }
            if (Syringe.SyringeSlider.value>=20&&Syringe.SyringeSlider.value<=70)
            {
                Character1.SetActive(true);
                FalseCharacter1.SetActive(false);
            }
            if (Syringe.SyringeSlider.value>70&&Syringe.SyringeSlider.value<=170)
            {
                Character1.SetActive(true);
                FalseCharacter1.SetActive(false);
                Character2.SetActive(true);
                FalseCharacter2.SetActive(false);
            }
            if (Syringe.SyringeSlider.value>170)
            {
                Character1.SetActive(true);
                FalseCharacter1.SetActive(false);
                Character2.SetActive(true);
                FalseCharacter2.SetActive(false);
                Character3.SetActive(true);
                FalseCharacter3.SetActive(false);
            }
            cam.GetComponent<CameraFollowing>().enabled=false;
            cam2.GetComponent<FinalCameraPosition>().enabled=true;
            UI.SetActive(true);

            Syringe.Score*=3;
            TotalScoresTxt.text=" 3x "+Syringe.Score;
        }
    }
}
