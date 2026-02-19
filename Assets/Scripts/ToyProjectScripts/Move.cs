using UnityEngine;

public class Move : MonoBehaviour
{

    private float speedY = 2.5f;
    public float speedX = 0f;
    //private float currentSpeedX = 0f;
    //private float increaseSpeedX = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       
        Vector3 moveYPos = transform.position;
        moveYPos.y -= speedY * Time.deltaTime;
        transform.position = moveYPos;


        //Vector3 moveXPos = transform.position;
        //moveXPos.x += speedX * Time.deltaTime;
        //transform.position = moveXPos;




        if (moveYPos.y < -2.5f)
        {
            speedY = 0f;


            transform.position += transform.right * speedX * Time.deltaTime;

        }

        if (transform.position.x > 5.5f)
        {
            Destroy(gameObject);
        }
    }

   
}
