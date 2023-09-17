using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemove : MonoBehaviour
{
    public Transform spriteTransform;
    public float moveSpeed = 7f;
    public bool directionright = true;
    public Vector3 targetPosition = new Vector3(-7.6f, -3f, 0f);
    private void Start()
    {
        spriteTransform.position = new Vector3(-7.6f, -3f, 0f);
    }
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
	    if (horizontalInput > 0)
	        {
		        gameObject.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f); 
			        //flip for when moving right
                directionright = true;
	        }
	    if (horizontalInput < 0)
	        {
		        gameObject.transform.localScale = new Vector3(-0.4f, 0.4f, 0.4f);
			    //flip for when moving left
                directionright = false;
	        }
	    Vector2 movement = new Vector2(horizontalInput, 0) * moveSpeed * Time.deltaTime;
	    transform.Translate(movement);
	   	    //movement of character
	
    }
}
