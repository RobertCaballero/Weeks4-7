using UnityEngine;

public class Spawning3 : MonoBehaviour
{

    public GameObject Object3;


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
        Instantiate(Object3, transform.position, Quaternion.identity);
    }

}
