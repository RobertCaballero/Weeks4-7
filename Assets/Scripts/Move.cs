using UnityEngine;

public class Move : MonoBehaviour
{

    private float speed = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 moveYPos = transform.position;
        moveYPos.y -= speed * Time.deltaTime;
        transform.position = moveYPos;


        if (moveYPos.y < -2.5f)
        {
            Destroy(gameObject);
        }
    }
}
