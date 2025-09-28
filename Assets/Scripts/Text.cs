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
        if(sec >= 8){
            sudgText.text = " "; //reset text
        }
        if(sec >= 13){
            sudgText.text = "Or you could leave if you hold the 'esc' key...";
        }
        if(sec >= 17){
            sudgText.text = " "; //reset text
        }
        if(sec >= 22){
            sudgText.text = "what is an 'esc' key?..";
        }
        if(sec >= 25){
            sudgText.text = " "; //reset text
        }
        if(sec >= 36){
            sudgText.text = "The sky is beautiful this time of year...";
        }
        if(sec >= 40){
            sudgText.text = "I like to watch the clouds drifting away."; //reset text
        }
        if(sec >= 45){
            sudgText.text = " "; //reset text
        }
    }
}
