﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class PlatformManager : MonoBehaviour {

    public Transform prefab;

    public Transform[] platforms; 
    public int numberOfObjects;
    public float recycleOffset;
    public Vector3 startPosition;
    public Vector3 minSize, maxSize, minGap, maxGap;
    public float minY, maxY;
    public float minX, maxX; 

    private Vector3 nextPosition;
    private Queue<Transform> objectQueue; 

    void Start()
    {
        objectQueue = new Queue<Transform>(numberOfObjects);
        for (int i = 0; i < numberOfObjects; i++)
        {
            prefab = platforms[Random.Range(0, platforms.Length * 7) % platforms.Length]; 
            objectQueue.Enqueue((Transform)Instantiate(prefab));
        }
        nextPosition = startPosition;
        for (int i = 0; i < numberOfObjects; i++)
        {
            Recycle();
        }
    }

    void Update()
    {
        if (objectQueue.Peek().localPosition.y + recycleOffset < Globals.distanceTraveledY)
        {
            Recycle();
        }
        
    }

    private void Recycle()
    {
        Vector3 scale = new Vector3(
            Random.Range(minSize.x, maxSize.x),
            Random.Range(minSize.y, maxSize.y),
            Random.Range(minSize.z, maxSize.z));

        Vector3 position = nextPosition;
        position.x += scale.x * 0.5f;
        position.y += scale.y * 0.5f;

        Transform o = objectQueue.Dequeue();
        Breakers B = o.gameObject.GetComponentInChildren<Breakers>();

        if (B) {
            B.Reset(); 
        } 

        o.localScale = scale;
        o.localPosition = position;
        objectQueue.Enqueue(o);

        nextPosition += new Vector3(
            Random.Range(minGap.x, maxGap.x) + scale.x,
            Random.Range(minGap.y, maxGap.y),
            Random.Range(minGap.z, maxGap.z));

        /*if (nextPosition.y < minY)
        {
            nextPosition.y = minY + maxGap.y;
        }
        else if (nextPosition.y > maxY)
        {
            nextPosition.y = maxY - maxGap.y;
        }*/

        if (nextPosition.x < minX)
        {
            nextPosition.x = minX + maxGap.x;
        }
        else if (nextPosition.x > maxX)
        {
            nextPosition.x = maxX - maxGap.x; 
        }


    }
}//end of class
