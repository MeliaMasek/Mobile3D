using UnityEngine;
// code borrowed and modified by user hash on youtube https://www.youtube.com/watch?v=hWpoB7sHY_U
public class ButtonMovement : MonoBehaviour
{
    private bool moveLeft;
    private bool moveRight;
    private bool moveDown;
    private bool moveUp;
    private Rigidbody rb;
    private float moveVert;
    private float moveHort;
    public float speed = 300f;
    
    private Vector3 currentMovement;
    private bool isMovementPressed;
    public float rotationPerFrame = 15f;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        DpadMovement();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(moveHort * Time.deltaTime, rb.velocity.y, moveVert * Time.deltaTime);
    }

    public void PointerDownLeft()
    {
        moveLeft = true;
        RotatationHandling();
    }
    public void PointerUpLeft()
    {
        moveLeft = false;
    }

    public void PointerDownRight()
    {
        moveRight = true;
    }
    public void PointerUpRight()
    {
        moveRight = false;
    }
    
    public void PointerDownUp()
    {
        moveUp = true;
    }
    public void PointerUpUp()
    {
        moveUp = false;
    }
    
    public void PointerDownDown()
    {
        moveDown = true;
    }
    public void PointerUpDown()
    {
        moveDown = false;
    }

    public void DpadMovement()
    {
        if (moveLeft)
        {
            moveHort = -speed;
        }
        else if (moveRight)
        {
            moveHort = speed;
        }
        else
        {
            moveHort = 0;
        }
        
        if (moveUp)
        {
            moveVert = speed;
        }
        else if (moveDown)
        {
            moveVert = -speed;
        }
        else
        {
            moveVert = 0;
        }
    }
    
    void RotatationHandling()
    {
        Vector3 positionToLookAt;

        positionToLookAt.x = currentMovement.x;
        positionToLookAt.y = 0f;
        positionToLookAt.z = currentMovement.z;
        
        Quaternion currentRotation = transform.rotation;

        if (isMovementPressed)
        {
            if (currentMovement != Vector3.zero) 
            {
                Quaternion targetRotation = Quaternion.LookRotation(positionToLookAt);
                transform.rotation = Quaternion.Slerp(currentRotation, targetRotation, rotationPerFrame * Time.deltaTime);
            }
        }
        Debug.Log("rotation");
    }
}
