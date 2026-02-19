using UnityEngine;

public class DespawnPlates : MonoBehaviour
{
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x > 5.5f) // If the plate goes beyond x = 5.5, it will be destroyed
        {
            Destroy(gameObject); // Destroys the plate 
        }


    }
}
