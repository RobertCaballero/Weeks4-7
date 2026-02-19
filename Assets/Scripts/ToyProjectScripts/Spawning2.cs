using UnityEngine;

public class Spawning2 : MonoBehaviour
{

    public GameObject Object2; // Created a game object variable to assign the prefab of steak to the spawner
    private float speedX = 3f; // Created a float variable to assign the speed of the steak when it is spawned.



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

        GameObject SpawnFood = Instantiate(Object2, transform.position, Quaternion.identity); // Instantiated the steak prefab at the position of the spawner with no rotation.
        Move SpawnFoods = SpawnFood.GetComponent<Move>(); // Created a variable to get the Move script component of the spawned steak.
        SpawnFoods.speedX = speedX; //Set the speedX value of the Move script to the speedX value in this script.

    }

    public void Speed(float value)// Created a method to change the speedX value with the slider.
    {
        speedX = value; //Made the speedX value be equal to the value of the slider. That way the steak moves faster or slower.
    }
}

