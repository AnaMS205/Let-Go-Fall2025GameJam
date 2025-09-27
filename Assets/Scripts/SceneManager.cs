using UnityEngine;

public class SceneManager : MonoBehaviour
{

    public StandForPlayer standActs;
    public Player player;

    // public AudioSource crash;
    // public AudioSource heaven;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //crash = GetComponent<AudioSource>();
        //heaven = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape")){
            Debug.Log("Quitting...");
            float sec = Time.deltaTime;
            if(sec >= 3){
                Application.Quit();
            }
        }
        
    }

    // public void PlayCrash(){
    //     crash.Play(0);
    // }

    // public void PlayHeaven(){
    //     heaven.Play(0);
    // }


}
