using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    public float moveSpeed;
    private Vector3 currentPos;
    private Vector3 newPos;
    private Vector3 move;

    // Update is called once per frame
    void Update()
    {
        currentPos = transform.position;
        float moveX = Input.GetAxisRaw("Vertical");
        float moveZ = Input.GetAxisRaw("Horizontal");

        move = new Vector3(moveX, 0, moveZ);
        move = Vector3.Normalize(move);

        Debug.Log(move);

        newPos = new Vector3(currentPos.x + move.x * moveSpeed * Time.deltaTime, currentPos.y, currentPos.z - move.z * moveSpeed * Time.deltaTime);

        transform.position = newPos;
    }
}
