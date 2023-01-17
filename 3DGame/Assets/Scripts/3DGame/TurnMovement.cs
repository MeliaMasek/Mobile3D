using UnityEngine;

public class TurnMovement : MonoBehaviour
{
    public float moveSpeed = .25f;
    public float snapDistance = .25f;
    
    public Vector3 targetPosition;
    public bool moving;

    void Update()
    {
        if (Input.GetButtonDown("Attack"))
        {
            transform.position += Vector3.forward;
            moving = true;
        }

        if (Vector3.Distance(transform.position, targetPosition) > snapDistance && moving)
        {
            transform.position += Vector3.forward * (moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = targetPosition;
            moving = false;
        }

        if (Input.GetAxisRaw("Vertical") == 1f)
        {
            targetPosition = transform.position + Vector3.forward;
            moving = true;
        }
        else if (Input.GetAxisRaw("Vertical") == -1f)
        {
            targetPosition = transform.position + Vector3.back;
            moving = true;
        }
    }
}
