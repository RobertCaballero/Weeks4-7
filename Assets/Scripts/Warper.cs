using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Warper : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //IF WE CLICK AND WE ARE NOT HOVERING UI

        bool shouldWarp = Mouse.current.leftButton.wasPressedThisFrame && !EventSystem.current.IsPointerOverGameObject();


        if (shouldWarp == true)
        {
            Vector3 currentMousePos = Mouse.current.position.ReadValue();
            transform.position = currentMousePos;

            //Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(currentMousePos);
            //worldMousePos.z = 0f; //No need for this to be changed. 
        }

    }
}
