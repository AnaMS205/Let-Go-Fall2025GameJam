using UnityEngine;

public class StandForPlayer : MonoBehaviour
{
    //public Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Space)){
            Hide();
        }
        
    }

    public void Hide(){
        Destroy(gameObject);
    }
}
