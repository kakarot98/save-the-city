using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiagonalSpawner : MonoBehaviour
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
            Vector3 parentPos = UnityEngine.Random.insideUnitSphere;
            //parentPos.x = parentPos.x >= 0 ? 1 : -1;
            //parentPos.y = parentPos.y >= 0 ? 1 : -1;
            obstacleBox1 = Instantiate(meteorPrefab, new Vector3(-parentPos.x, parentPos.y, parentPos.z), Quaternion.identity);


            currentMeteorSpawnTimer = 0f;
        }

    }
}

