using UnityEngine;
using TMPro;

public class Text : MonoBehaviour
{
    public TMP_Text sudgText;
    float sec;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sudgText.text = " "; //start with blank   
    }

    public void QuitButton(){
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        sec += Time.deltaTime;

        if(sec >= 5){
            sudgText.text = "Maybe try pressing 'space'..?";
        }
        if(sec >= 10){
            sudgText.text = " "; //reset text
        }
        if(sec >= 23){
            sudgText.text = "Or you could leave if you hold the 'esc' key...";
        }
        if(sec >= 27){
            sudgText.text = " "; //reset text
        }
        if(sec >= 34){
            sudgText.text = "what is an 'esc' key?..";
        }
        if(sec >= 38){
            sudgText.text = " "; //reset text
        }
        if(sec >= 55){
            sudgText.text = "The sky is beautiful this time of year...";
        }
        if(sec >= 60){
            sudgText.text = "I like to watch the clouds drifting away."; //reset text
        }
        if(sec >= 66){
            sudgText.text = " "; //reset text
        }
        if(sec >= 200){
            sudgText.text = "I miss my wife..."; //reset text
        }
        if(sec >= 205){
            sudgText.text = " "; //reset text
        }
    }
}
