using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class BarrelGym : MonoBehaviour
{

    public List<GameObject> currentKnives = new List<GameObject>();

    public GameObject spawnKnifes;

    Vector2 v = new Vector2(2.12f, -0.86f);
    Vector2 v2 = new Vector2(2.32f, 1.36f);
    Vector2 v3 = new Vector2(-2.84f, 1.16f);
    Vector2 v5 = new Vector2(-2.87f, -0.76f);

 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       //for (int i = 0; i < knife.Count; i++)
       // {
       //     GameObject currentKnifes = knife[i];
       //     Debug.Log(currentKnifes);

       // }


        GameObject spawnObject = Instantiate(spawnKnifes, transform.position, Quaternion.identity);
        GameObject spawnObject2 = Instantiate(spawnKnifes, v, Quaternion.identity);
        GameObject spawnObject3 = Instantiate(spawnKnifes, v2, Quaternion.identity);
        GameObject spawnObject4 = Instantiate(spawnKnifes, v3, Quaternion.identity);
        GameObject spawnObject5 = Instantiate(spawnKnifes, v5, Quaternion.identity);

        currentKnives.Add(spawnObject);
        currentKnives.Add(spawnObject2);
        currentKnives.Add(spawnObject3);
        currentKnives.Add(spawnObject4);
        currentKnives.Add(spawnObject5);



    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}

public class Knife
{

}
