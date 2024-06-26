using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float length, newPos, totalDist, dist, startPos;
    public GameObject cam;
    public float parallaxEffect;

    void Start()
    {
        totalDist = 0;
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
        Debug.Log(startPos + length);
    }

    void Update()
    {
        dist = Time.deltaTime * parallaxEffect;
        newPos = transform.position.x + dist;
        totalDist += dist;

        if (totalDist >= length)
        {
            Debug.Log("Exceeded Move Limit");
            totalDist -= length;
            newPos = startPos + totalDist;
            Debug.Log(newPos);
        }

        transform.position = new Vector3(newPos, transform.position.y, transform.position.z);
    }
}
