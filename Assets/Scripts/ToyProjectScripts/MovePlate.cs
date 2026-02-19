using UnityEngine;

public class MovePlate : MonoBehaviour
{

    public float speed = 3f;
    private float currentSpeed = 3f;
    private float increaseSpeed =1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += transform.right * currentSpeed * Time.deltaTime;
        currentSpeed = speed + increaseSpeed;

        
    }


    public void Speed(float value)
    {
        speed = value;
    }
}
