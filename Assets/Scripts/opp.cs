using UnityEngine;

public class opp : MonoBehaviour
{
    public float minSize = 1.0f;
    public float maxSize = 30f;
    Rigidbody2D rb;
    public float minSpeed = 300f;
    public float maxSpeed = 500f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randomSize = Random.Range(minSize, maxSize);
        transform.localScale = new Vector3(randomSize, randomSize, 1);

        rb = GetComponent<Rigidbody2D>();

        Vector2 randomDirection = Random.insideUnitCircle;
        float randomSpeed = Random.Range(minSpeed, maxSpeed);
        rb.AddForce(randomDirection * randomSpeed);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
