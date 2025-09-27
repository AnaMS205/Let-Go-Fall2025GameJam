using UnityEngine;

public class CamraASpect : MonoBehaviour
{
    public float targetAspect = 16f/10f;

    public Camera _camera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _camera = GetComponent<Camera>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AdjustCamera(){
        float currentAspect = (float)Screen.width / (float)Screen.height;
        float scaleHeight = currentAspect / targetAspect;

        if(scaleHeight < 1.0f){
            float scaleWidth = 1.0f;
            _camera.rect = new Rect((1.0f - scaleWidth) / 2.0f, 0, scaleWidth, 1.0f);
        } else {
            float scaleWidth = 1.0f/ scaleHeight;
            _camera.rect = new Rect(0, (1.0f - scaleWidth)/2.0f, 1.0f, scaleWidth);
        }
    }
}
