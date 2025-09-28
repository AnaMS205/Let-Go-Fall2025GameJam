using UnityEngine;

public class SceneManager : MonoBehaviour
{

    public StandForPlayer standActs;
    public Player player;

    float sec;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape")){
            //Debug.Log("Quitting...");
            Application.Quit();
            sec += Time.deltaTime;
            if(sec >= 3){
                Application.Quit();
            }
        }
        
    }



}
