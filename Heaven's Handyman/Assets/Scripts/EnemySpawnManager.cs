using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class EnemySpawnManager : MonoBehaviour {
    public GameObject prefab;

    public GameObject[] enemies;
    public int numberOfObjects;
    public float recycleOffset;
    public Vector3 startPosition;
    public Vector3 minSize, maxSize, minGap, maxGap;
    public float minY, maxY;
    public float minX, maxX;

    private Vector3 nextPosition;
    private Queue<GameObject> objectQueue;
    //private List<Transform> enemyList; 

    void Start()
    {
        objectQueue = new Queue<GameObject>(numberOfObjects);
       
        for (int i = 0; i < numberOfObjects; i++)
        {
            prefab = enemies[Random.Range(0, enemies.Length * 7) % enemies.Length];
            objectQueue.Enqueue(Instantiate(prefab));

            //Debug.Log(objectQueue); 
           
        }
        nextPosition = startPosition;
        for (int i = 0; i < numberOfObjects; i++)
        {
            Recycle();

        }
    }

    void Update()
    {
        Debug.Log(objectQueue.Peek());

        if (objectQueue.Peek() == null)
        {

            objectQueue = new Queue<GameObject>(numberOfObjects);

            for (int i = 0; i < numberOfObjects; i++)
            {
                prefab = enemies[Random.Range(0, enemies.Length * 7) % enemies.Length];
                objectQueue.Enqueue(Instantiate(prefab));

            }
            nextPosition = startPosition;
            for (int i = 0; i < numberOfObjects; i++)
            {
                Recycle();

            }

        }//end of if

        else if (objectQueue.Peek().transform.localPosition.y + recycleOffset < Globals.distanceTraveledY)
        {

            Recycle();
        }

    }//end of update

    private void Recycle()
    {
        Vector3 scale = new Vector3(
            Random.Range(minSize.x, maxSize.x),
            Random.Range(minSize.y, maxSize.y),
            Random.Range(minSize.z, maxSize.z));

        Vector3 position = nextPosition;
        position.x += scale.x * 0.5f;
        position.y += scale.y * 0.5f;


        GameObject n = objectQueue.Dequeue(); 
        Debug.Log(n);
        n.transform.localScale = scale;
        n.transform.localPosition = position;
        objectQueue.Enqueue(n);
        //Debug.Log(n); 

        /*Transform o = objectQueue.Dequeue();
            o.localScale = scale;
            o.localPosition = position;
            objectQueue.Enqueue(o);*/

      

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