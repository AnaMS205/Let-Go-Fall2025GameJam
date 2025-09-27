using UnityEngine;

public class Player : MonoBehaviour
{

    public int jumpForce = 30;
    public Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Jump();
        }
        
    }

    public void Jump(){
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
