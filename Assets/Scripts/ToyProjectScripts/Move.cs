using UnityEngine;

public class Move : MonoBehaviour
{

    private float speedY = 2.5f; // This is the speed for the object to move downwards!
    public float speedX = 0f; //This is the speed the object will move when it reaches the specigic y position! Starts at 0 and changes when the condition is met!


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       
        Vector3 moveYPos = transform.position; // Here we place the object's current position and named it moveYPos so we can change the y value of the position without affecting the x and z values!
        moveYPos.y -= speedY * Time.deltaTime; // Here we change the y value to be moving negative to the speed we determined and the multiply it by Time.deltaTime so it moves each second!
        transform.position = moveYPos; // Here we set the position of the object to be the new position we just determined with the moveYPos variable!

        if (moveYPos.y < -2.5f)
        {
            speedY = 0f; // When the condition is met, we set the speedY variable to 0 so the object stops moving downwards.


            transform.position += transform.right * speedX * Time.deltaTime; // Here we move the object to the right by multiplying the right direction of the transform with the speedX variable and Time.deltaTime so it moves each second!

        }

        if (transform.position.x > 5.5f) // Createed and if statement for the object to be destroyed so the objects don't go outside of the screen. 
        {
            Destroy(gameObject); //GameObject is destroyed. 
        }
    }

   
}
