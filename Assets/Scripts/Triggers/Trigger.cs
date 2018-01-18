using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

    private bool entered = false;
    public AudioClip clipp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!entered)
        {
            GetComponent<AudioSource>().PlayOneShot(clipp);
            entered = true;
        }
    }
}
