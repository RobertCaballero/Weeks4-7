using UnityEngine;

public class Spawning : MonoBehaviour
{

    public GameObject Object1; // Created a game object variable to assign the prefab of cheese to the spawner.
    private float speedX = 3f; // Created a float variable to assign the speed of the cheese when it is spawned.

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
        //Instantiate(Object1, transform.position, Quaternion.identity);


        GameObject SpawnFood = Instantiate(Object1, transform.position, Quaternion.identity); // Instantiated the cheese prefab at the position of the spawner with no rotation. That way it sapwns right were the spawner is located.
        Move SpawnFoods = SpawnFood.GetComponent<Move>(); // Grab the Move script from eachh spawned cheese.
        SpawnFoods.speedX = speedX; //Set the speedX value of the Move script to the speedX value in this script . That way each spawned cheese will have the same speedX as the speedX variable in this script.

    }

         public void Speed(float value) //Created a method to change the speedX value with the slider.
    {
        speedX = value; //Made the speedX value be equal to the value of the slider. That way the chees moves faster or slower.
    }

}


