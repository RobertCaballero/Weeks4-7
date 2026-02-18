using UnityEngine;

public class DespawnPlates : MonoBehaviour
{
    public float destroyTime;
    private float destroyProg;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        destroyProg += Time.deltaTime;

        if (destroyProg > destroyTime)
        {
            //destroyProg = 0f;
            Destroy(gameObject);

        }
    }
}
