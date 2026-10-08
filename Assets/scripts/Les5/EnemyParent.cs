using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    protected int health = 100;
    protected int speed = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     move();    
      
    }
    
    protected virtual void move()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pewpew"))
        {
            health -= 10;
            Destroy(other.gameObject);
            Debug.Log("Enemy hit! Health: " + health);
            if (health <= 0)
         {
             Destroy(gameObject);
         }
        }
    }
}
