using UnityEngine;

public class Opdracht1_4 : MonoBehaviour
{
    public int watisgrooter(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int result = watisgrooter(5, 10);
        Debug.Log(result);
        int result2 = watisgrooter(15, 10);
        Debug.Log(result2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
