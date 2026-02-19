using UnityEngine;
using UnityEngine.UI;

public class RotateHandle : MonoBehaviour
{
    public GameObject Handle;
    private float rotationSpeed = 100f;
    public float CurrentRotationSpeed;
    private float RotationSpeed = 100f;
    public Slider RotationSlider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        CurrentRotationSpeed = rotationSpeed + RotationSpeed;

        Vector3 Rotation = transform.eulerAngles;
        Rotation.z += CurrentRotationSpeed * Time.deltaTime;

        transform.eulerAngles = Rotation;
    }

    public void Speed(float value)
    {
        RotationSpeed =  value;
    }
}
