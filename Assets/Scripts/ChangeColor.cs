using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Slider slider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Colour()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();

        Color randomColour = new Color(Random.value, Random.value, Random.value);

        spriteRenderer.color = randomColour;
    }

    public void Rotation(float value)
    {
        slider.value = value;

        Vector3 newRotation = transform.eulerAngles;
        newRotation.z += value;

        transform.eulerAngles = newRotation;
    }
}
