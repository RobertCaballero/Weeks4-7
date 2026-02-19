using UnityEngine;

public class Spawning4 : MonoBehaviour
{

    public GameObject Object4; //Created a game object variable to assign the prefab of bread to the spawner
    private float speedX = 3f; // Created a float variable to assign the speed of the bread when it is spawned.

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

        GameObject SpawnFood = Instantiate(Object4, transform.position, Quaternion.identity);// Instantiated the bread prefab at the position of the spawner with no rotation.
        Move SpawnFoods = SpawnFood.GetComponent<Move>(); // Accessed the Move script attached to the bread prefab and assigned it to a variable called SpawnFoods.
        SpawnFoods.speedX = speedX; // Assigned the value of speedX to the speedX variable in the Move script of the bread prefab, which will control the speed of the bread when it is spawned.

    }

    public void Speed(float value) // Created a method to change the speedX value with the slider.
    {
        speedX = value; // Made the speedX value be equal to the value of the slider. That way the bread moves faster or slower.
    }
}
