using UnityEngine;

public class BrickScript : MonoBehaviour
{
    public int pointValue = 1;

    public bool breakable = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setBrick(int Value, Color color)
    {
        pointValue = Value;
        var sr = GetComponent<SpriteRenderer>();
        Debug.Log("sr = " + sr);
        if (sr != null)
            sr.color = color;

    }
}
