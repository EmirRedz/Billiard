using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour {
    public AudioSource wallSound;
    public AudioSource ballSound;
    public GameObject ball;
	// Use this for initialization
	void Start ()
    {
        ballSound = GetComponent<AudioSource>();
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Target")
        {
            ballSound.Play();
        }
        if(collision.gameObject.tag=="Wall")
        {
            wallSound.Play();
        }
        if(collision.gameObject.tag=="Respawn")
        {
            ball.transform.position = new Vector3(3.34f, 0, 0);
        }
    }

  
}
