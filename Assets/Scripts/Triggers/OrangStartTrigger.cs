using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangStartTrigger : MonoBehaviour {

    public GameObject orang;
    public AudioClip clip;
    private bool TRIGGERED = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!TRIGGERED)
        {
            orang.GetComponent<Animator>().Play("orangSpinUp");
            GetComponent<AudioSource>().PlayOneShot(clip,1f);

            TRIGGERED = true;
        }
        
    }
}
