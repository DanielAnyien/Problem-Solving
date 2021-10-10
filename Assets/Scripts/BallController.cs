using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    public KeyCode upButton = KeyCode.W;
	public KeyCode downButton = KeyCode.S;
    public KeyCode rightButton = KeyCode.D;
    public KeyCode leftButton = KeyCode.A;
	public float speed = 10.0f;
    public float yBoundary = 10.0f;
    public float xBoundary = 10.0f;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        Problem23();
    }

    void FixedUpdate()
    {
        string scname = SceneManager.GetActiveScene().name;

        if (scname == "Problem 4" || scname == "Problem 9")
        {
            MoveWithKeyBoard();
        }

        else if(scname == "Problem 5" || scname == "Problem 7" || scname == "Problem 8")
        {
            MoveWithCursor();
        }
    }

    private void Problem23()
    {
        rigidBody2D.AddForce(new Vector2(75, 75));
    }

    private void MoveWithKeyBoard()
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
            velocity.y = 0;
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
            velocity.x = 0;
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

    private void MoveWithCursor()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(cursorPos.x, cursorPos.y);
    }
}
