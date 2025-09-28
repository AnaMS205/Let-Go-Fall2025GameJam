using UnityEngine;

public class Player : MonoBehaviour
{
    public StandForPlayer stand;
    public AudioManager audioM;

    public int jumpForce = 30;
    public Rigidbody rb;

    Vector3 startPos = new Vector3 (0,0.5f,0);

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

        if(transform.position.y <= -20){
            audioM.PlayCrash();
            
            stand.GoBack();
            transform.position = startPos;
        }

        if(transform.position.y >= 10){
            audioM.PlayHeaven();
        }
        
    }

    public void Jump(){
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
