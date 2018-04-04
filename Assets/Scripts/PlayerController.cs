using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public int jumpHeight;
    private bool jumpUp = true;
    private bool dbljumpUp = true;
    float speedx, speedy;

	// Use this for initialization
	void Start () {
        speedx = 0; 
        speedy = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp(KeyCode.D)|| Input.GetKeyUp(KeyCode.A)||Input.GetKeyUp(KeyCode.RightArrow)|| Input.GetKeyUp(KeyCode.LeftArrow))
        {
            speedx = 0;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpUp)
            {
                jumpUp = false;
                Jump();
            }
            else if (dbljumpUp)
            {
                dbljumpUp = false;
                Jump();
            }

        }

        speedy = GetComponent<Rigidbody2D>().velocity.y;
        GetComponent<Rigidbody2D>().velocity = new Vector2(speedx, speedy);

        if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow))
        {
            speedx = -moveSpeed;
        }

        if (Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow))
        {
            speedx = moveSpeed;
        }
       
        

        speedy = GetComponent<Rigidbody2D>().velocity.y;
        GetComponent<Rigidbody2D>().velocity = new Vector2(speedx, speedy);

        if (speedx > 0)
        {
            transform.localScale = new Vector3(1,1,0);
        }
        else if (speedx < 0)
        {
            transform.localScale = new Vector3(-1, 1, 0);
        }
    }

    public void Jump()
    {
        Debug.Log("hoppin'");
        GetComponent<Rigidbody2D>().velocity = transform.up * jumpHeight;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        jumpUp = true;
        dbljumpUp = true;
    }
}
