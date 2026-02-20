using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ContactSensor : MonoBehaviour
{
    public Transform player;
    public UnityEvent OnEnter;
    public UnityEvent OnLeave;

    public UnityEvent<float> OnEnterWithValue;

    private SpriteRenderer hazardRenderer;
    private bool wasInTheHazard = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //OnEnterWithValue.Invoke(player.health);

        hazardRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

        bool isInTheHazard = (hazardRenderer.bounds.Contains(player.transform.position));

        if (isInTheHazard && wasInTheHazard == false)
        {
            wasInTheHazard = true;
            //WHAT WE WANT TO HAVE HAPPENED WHEN THE PLAYERS ENTERS THE SENSOR
            OnEnter.Invoke();

            Debug.Log("I have entered the water");

        }
        //IF WE HAVE EXITED OUT OF THE HAZARD AND WE WERE PREVIOUSLY IN THE HAZARD
        //THEN WE RESET
        else if (!isInTheHazard && wasInTheHazard)
        {
            wasInTheHazard = false;

            //WHAT WE WANT TO HAVE HAPPENED WHEN THE PLAYERS EXISTS THE SENSOR
            OnLeave.Invoke();
            Debug.Log("I have exit the water");
        }

    }
}
