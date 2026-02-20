using UnityEngine;

public class Snake : MonoBehaviour
{

    public int damage;
    public DungeonPlayer player;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
      

    }

    public void ApplyDamage()
    {
        player.TakingDamage(damage);
    }
}
