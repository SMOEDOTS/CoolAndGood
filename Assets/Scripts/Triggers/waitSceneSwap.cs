using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class waitSceneSwap : MonoBehaviour {

    public float sec;

    private void go()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Use this for initialization
    void Start()
    {
        StartCoroutine(waitt());
    }

    IEnumerator waitt()
    {
        yield return new WaitForSeconds(sec);
        go();
    }
}
