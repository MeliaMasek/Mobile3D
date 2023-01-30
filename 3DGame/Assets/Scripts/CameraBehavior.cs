using System;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
