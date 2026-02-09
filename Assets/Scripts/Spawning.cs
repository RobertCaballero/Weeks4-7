using UnityEngine;

public class Spawning : MonoBehaviour
{

    public GameObject Object1;


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
        Instantiate(Object1, transform.position, Quaternion.identity);

    }

}
