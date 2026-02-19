using UnityEngine;

public class Spawning2 : MonoBehaviour
{

    public GameObject Object2;
 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }


    public void Spawn()
    {
        Instantiate(Object2, transform.position, Quaternion.identity);
    }

}

