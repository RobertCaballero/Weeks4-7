using UnityEngine;

public class Rotation : MonoBehaviour
{

    public float rotationSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z += rotationSpeed * Time.deltaTime;

        transform.eulerAngles = currentRotation;
    }

    public void StartSpin()
    {
        rotationSpeed = 100f;
    }

    public void StopSpin()
    {
        rotationSpeed = 0f;
    }
}
