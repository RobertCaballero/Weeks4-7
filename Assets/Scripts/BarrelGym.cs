using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class BarrelGym : MonoBehaviour
{

    public List<GameObject> knife = new List<GameObject>();

    public GameObject spawnKnifes;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       for (int i = 0; i < knife.Count; i++)
        {
            GameObject currentKnifes = knife[i];
            Debug.Log(currentKnifes);

        }


        GameObject spawnObject = Instantiate(spawnKnifes, transform.position, Quaternion.identity);
        knife.Add(spawnObject);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}

public class Knife
{

}
