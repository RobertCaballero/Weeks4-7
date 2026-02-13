using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class MoveTank : MonoBehaviour
{

    public float speed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Vector3 tankXPos = transform.position;
        //tankXPos.x += speed * Time.deltaTime;

        //transform.position = tankXPos;


        bool leftArrowHeld = Keyboard.current.leftArrowKey.isPressed;
        bool rightArrowHeld = Keyboard.current.rightArrowKey.isPressed;

        if (leftArrowHeld)
        {

            transform.position -= transform.right * speed * Time.deltaTime;

        }
       

        if (rightArrowHeld)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        

        
    }
}
