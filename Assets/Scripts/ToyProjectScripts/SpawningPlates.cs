using UnityEngine;

public class SpawningPlates : MonoBehaviour
{
    public GameObject ObjectPlate;
    public float waitingTime;
    private float waitingProg;
    
    private float speed = 3f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        waitingProg += Time.deltaTime;


        if (waitingProg > waitingTime)
        {

            waitingProg = 0f;

            GameObject SpawnedPlate = Instantiate(ObjectPlate, transform.position, Quaternion.identity);
            MovePlate SpawnedPlates = SpawnedPlate.GetComponent<MovePlate>();
            SpawnedPlates.speed = speed;


        }
    }

         public void Speed(float value)
    {
        speed = value;
    }

}
