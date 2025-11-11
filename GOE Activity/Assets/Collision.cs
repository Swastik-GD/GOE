using Unity.VisualScripting;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject cubePrefab;
    void Start()
    {
        
    }

    void Update()
    {
            
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collision with Obstacle detected!");
            SpawnCube();
        }
    }

    void SpawnCube()
    {
        Instantiate(cubePrefab, new Vector3(Random.Range(-10, 10), 0.5f , Random.Range(-10, 10)), Quaternion.identity);
    }
}
