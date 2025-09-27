using UnityEngine;

public class CloudMove : MonoBehaviour
{
    public SpawnCloud spawner;

    public float speed;
    public Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = Random.Range(0.5f, 3f);
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = Random.Range(0.5f, 3f);
        Vector3 newPos = transform.position;
        newPos.x += speed*Time.deltaTime;
        transform.position = newPos;

        if (transform.position.x >= 130){
            spawner.spawnNum ++;
            Destroy(gameObject);
            
        }

        
    }
}
