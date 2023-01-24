using UnityEngine;

//code borrowed and modified from xOctoManx from Youtube https://www.youtube.com/watch?v=9n1NrP8bpyA
public class TurnMovement : MonoBehaviour
{
    private Vector3
        up = Vector3.zero,
        right = new Vector3(0, 90, 0),
        down = new Vector3(0, 180, 0),
        left = new Vector3(0, 270, 0),
        currentDirection = Vector3.zero;

    private Vector3 nextPos, destination, direction;

    public float speed;
    public float rayLength = 1f;
    private bool canMove;

    private void Start()
    {
        currentDirection = up;
        nextPos = Vector3.forward;
        destination = transform.position;
    }

    private void Update()
    {
        MoveUp();
        MoveDown();
        MoveLeft();
        MoveRight();
    }

    private void MoveUp()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow))

        {
            nextPos = Vector3.forward;
            currentDirection = up;
            canMove = true;
        }

        if (Vector3.Distance(destination, transform.position) <= .00001f)
        {
            transform.localEulerAngles = currentDirection;
            if (canMove)
            {
                if (ValidMovement())
                {
                    destination = transform.position + nextPos;
                    direction = nextPos;
                    canMove = false;
                }
            }
        }
    }

    private void MoveDown()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            nextPos = Vector3.back;
            currentDirection = down;
            canMove = true;
        }

        if (Vector3.Distance(destination, transform.position) <= .00001f)
        {
            transform.localEulerAngles = currentDirection;
            if (canMove)
            {
                if (ValidMovement())
                {
                    destination = transform.position + nextPos;
                    direction = nextPos;
                    canMove = false;
                }
            }
        }
    }

    private void MoveRight()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            nextPos = Vector3.right;
            currentDirection = right;
            canMove = true;
        }

        if (Vector3.Distance(destination, transform.position) <= .00001f)
        {
            transform.localEulerAngles = currentDirection;
            if (canMove)
            {
                if (ValidMovement())
                {
                    destination = transform.position + nextPos;
                    direction = nextPos;
                    canMove = false;
                }
            }
        }
    }

    private void MoveLeft()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            nextPos = Vector3.left;
            currentDirection = left;
            canMove = true;
        }

        if (Vector3.Distance(destination, transform.position) <= .00001f)
        {
            transform.localEulerAngles = currentDirection;
            if (canMove)
            {
                if (ValidMovement())
                {
                    destination = transform.position + nextPos;
                    direction = nextPos;
                    canMove = false;
                }
            }
        }
    }

    bool ValidMovement()
    {
        Ray tempRay = new Ray(transform.position + new Vector3(0, .25f, 0), transform.forward);
        RaycastHit rayHit;
        Debug.DrawRay(tempRay.origin, tempRay.direction, Color.blue);

        if (Physics.Raycast(tempRay, out rayHit, rayLength))
        {
            if (rayHit.collider.attachedRigidbody)
            {
                return false;
            }            
        }
        return true;
    }

    public void UpButton()
    {
      MoveUp();
    }

    public void DownButton()
    {
        MoveDown();
    }

    public void LeftButton()
    {
        MoveLeft();
    }

    public void RightButton()
    {
        MoveRight();
    }
}
