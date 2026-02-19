using UnityEngine;

public class SpawningPlates : MonoBehaviour
{
    public GameObject ObjectPlate; // Created a public variable to assign the plate prefab in the Unity editor
    public float waitingTime; // Time to wait before spawning the next plate
    private float waitingProg; // Progress of waiting time

    private float speed = 3f; // Speed at which the plates will move



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        waitingProg += Time.deltaTime; // Increment the waiting progress by each second


        if (waitingProg > waitingTime) // Check if the waiting progress is greater that the waiting time
        {

            waitingProg = 0f; // Reset the waiting progress to 0

            GameObject SpawnedPlate = Instantiate(ObjectPlate, transform.position, Quaternion.identity); // Spawn a new plate at the position of the SpawningPlates object with no rotation
            MovePlate SpawnedPlates = SpawnedPlate.GetComponent<MovePlate>(); // Get the MovePlate component from the spawned plate
            SpawnedPlates.speed = speed; // Set the speed of the spawned plate to the speed variable defined in this script


        }
    }

         public void Speed(float value) // Create a public methor to change the speed of the plates with the slider!
    {
        speed = value;// Set the speed value equal to the value of the slider
    }

}
