using UnityEngine;

public class Brute : EnemyParent
{
    void Awake()
    {
        speed = 2;
        health = 200;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

}
