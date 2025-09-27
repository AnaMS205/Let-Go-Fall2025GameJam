using UnityEngine;

public class StandForPlayer : MonoBehaviour
{
    Vector3 startPos = new Vector3 (0,-1,0);
    Vector3 movePos = new Vector3 (-15,-1,0);

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Space)){
            Hide();
        }
        
    }

    public void Hide(){
        transform.position = movePos;
    }

    public void GoBack(){
        transform.position = startPos;
    }
}
