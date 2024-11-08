using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -15;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe destroyed");
            Destroy(gameObject);
        }
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
}
