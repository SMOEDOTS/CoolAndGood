using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Psst1Controller : MonoBehaviour {

    public AudioClip ohno;

	// Use this for initialization
	void Start () {
        StartCoroutine(beaned());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator beaned()
    {
        
        yield return new WaitForSeconds(0.5f);
        GetComponent<AudioSource>().PlayOneShot(ohno);

    }
}
