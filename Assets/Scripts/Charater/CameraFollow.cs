using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Character;
    private Vector3 updatePosition = Vector3.zero;
    private Vector3 currentPosition = Vector3.zero;

    private float followDrag;
    private void Start()
    {
        currentPosition = transform.position;
    }
    private void Update()
    {
        updatePosition.x = Character.transform.position.x - 3.1f;
        updatePosition.y = Character.transform.position.y + 6.61f;
        updatePosition.z = Character.transform.position.z;
        currentPosition = new Vector3(updatePosition.x, updatePosition.y, updatePosition.z);
        transform.position = currentPosition;
    }
}
