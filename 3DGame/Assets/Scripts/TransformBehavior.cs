using UnityEngine;

public class TransformBehavior : MonoBehaviour
{
    public Vector3Data v3data;
    Vector3 resetPos = new Vector3(0, (float).35, -5);
    public void ResetToZero()
    {
        transform.position = resetPos;
    }
    
    public void ResetFloor()
    {
        transform.position = Vector3.zero;
    }
    public void SetV3Value()
    {
        v3data.value = transform.position;
    }
    public void Update()
    {
        SetV3Value();
    }
}
