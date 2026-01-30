using UnityEngine;

public class Flipper : MonoBehaviour
{

    public float speed;
    //public Camera gameCamera; 
    private float direction = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * transform.right * speed * Time.deltaTime;
    }

    public void Move()
    {
        speed = 1f;
    }

    public void Stop ()
    {
        speed = 0f;
    }

    public void Direction()
    {
        direction *= -1f;
    }
}
