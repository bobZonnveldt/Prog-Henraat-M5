using System.Collections;
using UnityEngine;

public class Elf : EnemyParent
{
    void Awake()
    {
        speed = 4;
        health = 50;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(ToggleVisibility());
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    IEnumerator ToggleVisibility()
    {
        Renderer renderer = GetComponentInChildren<Renderer>();

        while (true)
        {
            yield return new WaitForSeconds(3f);
            renderer.enabled = false;
            yield return new WaitForSeconds(0.5f);
            renderer.enabled = true;
        }
    }
}
