using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    public KeyCode upButton = KeyCode.W;
	public KeyCode downButton = KeyCode.S;
    public KeyCode rightButton = KeyCode.D;
    public KeyCode leftButton = KeyCode.A;
	public float speed = 10.0f;
    public float yBoundary = 5f;
    public float xBoundary = 5f;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 velocity = rigidBody2D.velocity;

        if(Input.GetKey(upButton))
        {
			velocity.y = speed;
		}

		else if(Input.GetKey(downButton))
		{
			velocity.y = -speed;
		}

		else 
		{
			velocity.y= 0f;
		}

        if(Input.GetKey(leftButton))
        {
            velocity.x = -speed;
        }

        else if(Input.GetKey(rightButton))
        {
            velocity.x = speed;
        }

        else
        {
            velocity.x = 0f;
        }


        rigidBody2D.velocity = velocity;

		Vector3 position = transform.position;

		if(position.y > yBoundary)
		{
			position.y = yBoundary;
		}

		else if(position.y < -yBoundary)
		{
			position.y = -yBoundary;
		}

        else if(position.x > xBoundary)
        {
            position.x = xBoundary;
        }

        else if(position.x < -xBoundary)
        {
            position.x = -xBoundary;
        }

		transform.position = position;
    }
}
