using UnityEngine;
using UnityEngine.InputSystem;

public class DungeonPlayer : MonoBehaviour
{
    public int Health;
    private float speed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool leftArrowHeld = Keyboard.current.leftArrowKey.isPressed;
        bool rightArrowHeld = Keyboard.current.rightArrowKey.isPressed;
        bool upArrowHeld = Keyboard.current.upArrowKey.isPressed;
        bool downArrowHeld = Keyboard.current.downArrowKey.isPressed;

        if (leftArrowHeld)
        {

            transform.position -= transform.right * speed * Time.deltaTime;

        }


        if (rightArrowHeld)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }

        if (upArrowHeld)
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }

        if (downArrowHeld)
        {
            transform.position -= transform.up * speed * Time.deltaTime;
        }

        if (Health < 0)
        {
            Destroy(gameObject);
        }

    }

    public void TakingDamage(int damage)
    {
        Health -= damage;
    }


}
