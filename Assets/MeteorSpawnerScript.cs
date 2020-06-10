using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawnerScript : MonoBehaviour
{
    public GameObject meteorPrefab;
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
            Vector3 parentPos = transform.position;
            obstacleBox1 = Instantiate(meteorPrefab, new Vector3(-parentPos.x, parentPos.y, parentPos.z), Quaternion.identity);
            

            currentMeteorSpawnTimer = 0f;
        }

    }
}
