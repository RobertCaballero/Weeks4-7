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

    }


   public void Spawn ()
    {

        Vector2 spawnPos = Random.insideUnitCircle * 4;

        Instantiate(gymSpawner, spawnPos, Quaternion.identity);
       
    }

    
}
