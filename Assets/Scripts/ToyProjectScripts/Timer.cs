using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float timerValue = 6; // The initial value of the timer
    public float timerMinValue = 0; // The minimum value of the timer
    private float speed = 1f; // The base speed at which the timer decreases
    private float currentSpeed = 1f; // The current speed at which the timer will be decreasing
    private float increaseSpeed = 1f; // The additional speed that can be added to the base speed

    public Slider ClockTimer;
 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ClockTimer.minValue = timerMinValue; // Set the minimum value of the slider to match the timer's minimum value
    }

    // Update is called once per frame
    void Update()
    {

        timerValue -= Time.deltaTime * currentSpeed; // Decrease the timer value by every second , multiplied by the current speed

        if (timerValue < timerMinValue)
        {
            timerValue = 6; // Reset the timer value when it goes below the minimum value
        }

        ClockTimer.value = timerValue; // Update the slider's value to match the current timer value
        currentSpeed = speed + increaseSpeed; // Update the current speed by adding the base speed and the additional speed
    }

    public void Speed (float value) // Method to change the speed of the timer taking into account the sliders value so it goes faster.
    {
       
        increaseSpeed =  value; //Making the additional speed equal to the slider value

    }


}


