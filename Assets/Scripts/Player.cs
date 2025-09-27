using UnityEngine;

public class Player : MonoBehaviour
{
    public StandForPlayer stand;
    public SceneManager sceneM;

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
            //sceneM.PlayCrash();
            //reste position
            transform.position = startPos;
            
            stand.GoBack();
        }

        if(transform.position.y >= 10){
            //sceneM.PlayHeaven();
        }
        
    }

    public void Jump(){
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
