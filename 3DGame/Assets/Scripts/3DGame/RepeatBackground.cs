using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    public BoxCollider bCollider;
    public Rigidbody rb;
    private float width;
    private float scrollSpeed = -1f;

    private void Start()
    {
        bCollider = GetComponent<BoxCollider>();
        rb = GetComponent<Rigidbody>();

        width = bCollider.size.z;
        bCollider.enabled = false;

        rb.velocity = new Vector3(0, 0, scrollSpeed);
    }

    private void Update()
    {
        if (transform.position.z < -width)
        {
            Vector3 resetPostion = new Vector3(0, 0, width * 10f);
            transform.position = (Vector3)transform.position + resetPostion;

        }
    }
}
