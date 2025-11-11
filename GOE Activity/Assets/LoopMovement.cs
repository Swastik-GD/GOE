using UnityEngine;

public class LoopMovement : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 3f;
    public Rigidbody rb;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float x = Mathf.PingPong(Time.time * speed, distance) - distance / 2f;
        transform.position = startPos + new Vector3(x, 0, 0);
    }
}