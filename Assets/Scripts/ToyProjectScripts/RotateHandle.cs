using UnityEngine;
using UnityEngine.UI;

public class RotateHandle : MonoBehaviour
{
    public GameObject Handle; // Creating the game object for the handle
    private float rotationIncSpeed = 1f; // Variable of the increment of the rotation speed
    public float CurrentRotationSpeed; //Variable of the current rotation speed
    private float RotationSpeed = 50f; // Variable of the rotation speed
    public Slider RotationSlider; // Creating the slider for the rotation speed so it can be changed with the slider.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        CurrentRotationSpeed = rotationIncSpeed * RotationSpeed; // The current rotation speed will be determined by the increment of the rotation speed and the rotation speed.

        Vector3 Rotation = transform.eulerAngles; // Creating a vector3 variable for the rotation of the handle.
        Rotation.z += CurrentRotationSpeed * Time.deltaTime; // The rotation on the z axis will be determined by the current rotation speed multiplied by every second.

        transform.eulerAngles = Rotation; // The rotation of the handle will be determined by the rotation variable.
    }

    public void Speed(float value) // Created a method for the slider to change the increment of the rotation speed.
    {
        rotationIncSpeed =  value; // Making the increment of the rotation speed equal to the value of the slider so when it goes up the handler will rotate faster and when it goes down the handler will rotate slower.
    }
}
