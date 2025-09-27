using UnityEngine;

public class SpawnCloud : MonoBehaviour
{
    public GameObject cloud;
    private float YspawnRange = 15;  //15 to 60

    public int spawnNum = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            //-125 to 100
        
    }

    // Update is called once per frame
    void Update()
    {
        while(spawnNum > 0){
            Cloud();
            spawnNum --;
        }
        
        
    }

    public void Cloud(){
        float spawnPosY = Random.Range(YspawnRange, YspawnRange*4);
        float spawnPosX = -125;

        Vector3 randomPos = new Vector3 (spawnPosX, spawnPosY, 94);
        //Quaternion desiredRotation = Quaternion.Euler(90,90,0);

        Instantiate(cloud, randomPos,  Quaternion.identity );
    }
}
