using UnityEngine;

public class Spawning4 : MonoBehaviour
{

    public GameObject Object4;
    private float speedX = 3f;

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

        GameObject SpawnFood = Instantiate(Object4, transform.position, Quaternion.identity);
        Move SpawnFoods = SpawnFood.GetComponent<Move>();
        SpawnFoods.speedX = speedX;

    }

    public void Speed(float value)
    {
        speedX = value;
    }
}
