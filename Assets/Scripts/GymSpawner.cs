using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class GymSpawner : MonoBehaviour
{

    public GameObject gymSpawner;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       

        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Random.insideUnitCircle * 4;


    }


   public void Spawn ()
    {
        Quaternion originRotation = Quaternion.identity;

        Instantiate(gymSpawner, transform.position, Quaternion.identity);
       
    }

    
}
