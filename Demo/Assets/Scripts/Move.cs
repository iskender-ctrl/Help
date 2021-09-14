using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Touch touch;
    public float speedMofifiare;
    Transform player;
    public float speed = 12f;
    void Awake()
    {

    }
    private void Start()
    {
        player = GameObject.Find("Player").transform;
        //Time.timeScale = 0;
    }
    private void Update()
    {
        CharacterMove();
    }
   /* public void Play()
    {
        Time.timeScale = 1;
        play.SetActive(false);
    }*/
    void CharacterMove()
    {
        transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + (speed * Time.deltaTime));
        
        if(Input.touchCount>0)
        {
            touch = Input.GetTouch(0);
            if(touch.phase==TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedMofifiare*Time.deltaTime, transform.position.y,transform.position.z);
                if (touch.phase == TouchPhase.Stationary)
                {
                    transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedMofifiare * Time.deltaTime, transform.position.y, transform.position.z );
                }
            }
        }
    }
}
