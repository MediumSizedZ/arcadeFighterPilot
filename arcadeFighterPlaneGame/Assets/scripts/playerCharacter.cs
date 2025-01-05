using UnityEngine;

public class playerCharacter : MonoBehaviour
{
    public float turnSpeed;
    public Camera playerCamera;
    public float maximum = 50;
    public float minimum = -50;
    private Rigidbody rigidbod;
    Vector2 shiftDirection = Vector2.zero;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbod = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0;
	float vertical = 0;
	
	bool Left = Input.GetKey(KeyCode.LeftArrow);
        bool Right = Input.GetKey(KeyCode.RightArrow);
        bool Up = Input.GetKey(KeyCode.UpArrow);
        bool Down = Input.GetKey(KeyCode.DownArrow);

	if (Left && Up)
        {
            vertical = 0.707f;
            horizontal = -0.707f;
        }
        else if (Left && Down)
        {
            vertical = -0.707f;
            horizontal = -0.707f;
        }
        else if (Right && Up)
        {
            vertical = 0.707f;
            horizontal = 0.707f;
        }
        else if (Right && Down)
        {
            vertical = -0.707f;
            horizontal = 0.707f;
        }

        if (Left && Right)
        {
            horizontal = 0;
        }
        else if(Left)
        {
            horizontal = -1;
        }    
        else if(Right) 
        {
            horizontal = 1;
        }


        if(Up && Down) 
        {
            vertical = 0;
        }
        else if(Up)
        {
            vertical = 1;
        }
        else if(Down)
        {
            vertical = -1;
        }

	//shiftDirection = new Vector2(horizontal,vertical);
	rigidbod.linearVelocity = new Vector3(horizontal*turnSpeed,vertical*turnSpeed,0);

    }
}
