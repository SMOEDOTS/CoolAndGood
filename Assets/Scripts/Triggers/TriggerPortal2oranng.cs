using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPortal2oranng : MonoBehaviour {

    public bool entered = false;
    public AudioClip clipp;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!entered)
        {
            GetComponent<AudioSource>().PlayOneShot(clipp);
            entered = true;
        }
    }
}
