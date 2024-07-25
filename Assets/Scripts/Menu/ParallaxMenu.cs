using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    private RectTransform transformRect;
    private Vector2 newPos, startPos;
    private float totalDist, dist, length;
    public float parallaxEffect;

    void Start()
    {
        totalDist = 0;
        transformRect = GetComponent<RectTransform>();
        startPos = transformRect.anchoredPosition;
        length = transformRect.rect.width;
    }

    void Update()
    {
        dist = Time.deltaTime * parallaxEffect;
        totalDist += dist;
        newPos = new Vector2(totalDist, startPos.y);

        transformRect.anchoredPosition = newPos;

        if (totalDist >= length)
        {
            totalDist -= length;
            newPos = startPos;
        }
    }
}
