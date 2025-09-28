using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //public GameObject crashTrigger;

    public AudioSource crash;
    public AudioSource heaven;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //crash = GetComponent<AudioSource>();
        //heaven = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void PlayCrash(){
        int i=0;
        while(i<1){
            crash.Play(0);
            i++;
        }
    }

    public void PlayHeaven(){
        int i=0;
        while(i<1){
            heaven.Play(0);
            i++;
        }
    }
}
