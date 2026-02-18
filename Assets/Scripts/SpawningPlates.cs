using UnityEngine;

public class SpawningPlates : MonoBehaviour
{
    public GameObject ObjectPlate;
    public float waitingTime;
    private float waitingProg;
    public float destroyTime;
    private float destroyProg;
    private float speed = 1f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        waitingProg += Time.deltaTime;
        destroyProg += Time.deltaTime;

        if (waitingProg > waitingTime)
        {

            waitingProg = 0f;

            GameObject SpawnedPlate = Instantiate(ObjectPlate, transform.position, Quaternion.identity);
            MovePlate SpawnedPlates = GetComponent<MovePlate>();
            SpawnedPlates.speed = speed;

            if (destroyProg > destroyTime)
            {
                //destroyProg = 0f;
                Destroy(SpawnedPlate);

            }

        }

       

        //Destroy(gameObject);


    }
}
