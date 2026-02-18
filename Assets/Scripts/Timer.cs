using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float timerValue = 10;
    public float timerMinValue = 0;
    private float speed = 1f;
    private float currentSpeed = 1f;
    private float increaseSpeed = 1f;

    public Slider ClockTimer;
 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ClockTimer.minValue = timerMinValue;
    }

    // Update is called once per frame
    void Update()
    {

        timerValue -= Time.deltaTime * currentSpeed;

        if (timerValue < timerMinValue)
        {
            timerValue = 10;
        }

        ClockTimer.value = timerValue;
        currentSpeed = speed + increaseSpeed;
    }

    public void Speed (float value)
    {
       
        increaseSpeed =  value;

    }


}


