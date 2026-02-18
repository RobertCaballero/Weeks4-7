using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float timerValue = 10;
    public float timerMinValue = 0;
    //public float IncreaseSpeedValue = 5f;
    //public float IncreaseSpeedMinValue = 0;
    private float speed = 1f;
    private float currentSpeed = 1f;
    private float increaseSpeed = 1f;

    public Slider ClockTimer;
    //public Slider IncreaseSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ClockTimer.minValue = timerMinValue;
        //IncreaseSpeed.maxValue = IncreaseSpeedValue;
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

    //public void ChangeSpeed(float value)
    //{

    //}

    public void Speed (float value)
    {
       
        increaseSpeed =  value;

    }


}


