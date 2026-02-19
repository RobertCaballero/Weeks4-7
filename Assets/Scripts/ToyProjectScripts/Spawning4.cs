using UnityEngine;

public class Spawning4 : MonoBehaviour
{

    public GameObject Object4;
   


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
        Instantiate(Object4, transform.position, transform.rotation);

    }
}
