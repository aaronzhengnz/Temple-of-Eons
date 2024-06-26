using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float length, newPos, totalDist, dist;
    public GameObject cam;
    public float parallaxEffect;

    void Start()
    {
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        totalDist = totalDist += dist;
        newPos = transform.position.x;
        dist = Time.deltaTime * parallaxEffect;

        transform.position = new Vector3(newPos + dist, transform.position.y, transform.position.z);
    }
}
