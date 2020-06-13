using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawnerScript : MonoBehaviour
{
    public GameObject[] meteorAndStarPrefab;
    public float meteorSpawnTimer = 2f;
    private float currentMeteorSpawnTimer;
    void Start()
    {
        currentMeteorSpawnTimer = meteorSpawnTimer;
    }

    
    void Update()
    {
        SpawnMeteor();
    }

    public void SpawnMeteor()
    {
        currentMeteorSpawnTimer += Time.deltaTime;
        
        

        if (currentMeteorSpawnTimer >= meteorSpawnTimer)
        {
           
            GameObject obstacleBox1 = null;
            float meteorOrStar = Random.Range(0, 5);
            Vector3 parentPos = transform.position;
            if (meteorOrStar <= 3)
            {
                obstacleBox1 = Instantiate(meteorAndStarPrefab[0], new Vector3(parentPos.x, parentPos.y, parentPos.z), Quaternion.identity);
            }
            else if (meteorOrStar > 3) 
            {
                obstacleBox1 = Instantiate(meteorAndStarPrefab[1], new Vector3(parentPos.x, parentPos.y, parentPos.z), Quaternion.identity);
            }
            
            

            currentMeteorSpawnTimer = 0f;
        }

    }
}
