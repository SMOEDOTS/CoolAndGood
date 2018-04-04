using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitthenSpeak : MonoBehaviour {

    public float sec;
    public AudioClip clipp;

    private void go()
    {
            GetComponent<AudioSource>().PlayOneShot(clipp);
    }
    // Use this for initialization
    void Start () {
        StartCoroutine(waitt());
	}
	
    IEnumerator waitt()
    {
        yield return new WaitForSeconds(sec);
        go();
    }
}
