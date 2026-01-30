using UnityEngine;
using UnityEngine.Rendering;

public class Spawner : MonoBehaviour
{

    public GameObject spawningPrefab;

    public float waitDuration;
    public float destroyDuration;

    public Color pacerColour;

    public float pacerSpeed;

    private float waitProgress = 0f;
    private float destroyProgress;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {




        //EMPTY VECTOR 3
        //Vector3 originPostion = Vector3.zero;

        //EMPTY ROTATION
        //Quaternion originRotation = Quaternion.identity;

        //Instantiate(spawningPrefab, transform.position, Quaternion.identity);

        //SPAWN AT THE POSITION OF THE SPAWNER (WITH THE SPAWNER'S ROTATION)
        //Instantiate(spawningPrefab,transform.position, transform.rotation);

        //SPAWN AT THE ORIGIN
        //Instantiate(spawningPrefab);

    }

    // Update is called once per frame
    void Update()
    {

        waitProgress += Time.deltaTime;

        if (waitProgress > waitDuration)
        {
            //Instantiate(spawningPrefab, transform.position, Quaternion.identity);

            GameObject spawnedObject = Instantiate(spawningPrefab, transform.position, Quaternion.identity);

            //TypeOfComponent variableName = variableObject.GetComponent<TypeOfComponent>();

            Pacer spawnedPacer = spawnedObject.GetComponent<Pacer>();
            spawnedPacer.speed = pacerSpeed;

            //Set the colour of our pacer spawner to be pacerColour
            //SpriteRendered of the pacer

            SpriteRenderer spawnedRenderer = spawnedObject.GetComponent<SpriteRenderer>();
            spawnedRenderer.color = pacerColour;

            //Destroy(spawnedObject, destroyDuration);

            waitProgress = 0f;
        }

        
        

        //destroyProgress += Time.deltaTime;
        //if (destroyProgress > destroyDuration )
        //{
        //    Destroy(gameObject);
        //}

    }

    public void IncreasePacerSpeed()
    {
        pacerSpeed++;
        //pacerSpeec += 1;
    }
}
