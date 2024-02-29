using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour,IObjectPool
{
    [SerializeField] private Transform holder;
   [SerializeField] private List<GameObject> enemyPool;
   [SerializeField] private GameObject enemyToSpawn;
    [SerializeField] private Transform spawnPos;
    private float spawnTimer;
    private float spawnTimerMax =2f;
    private int amountToSpawn=20;
   [SerializeField] private float spawnOffsetX = 20f;
   [SerializeField] private float spawnOffsetY = 20f;

    private void Start()
    {
        GeneratePool();
    }
    private void LateUpdate()
    {
        if (spawnTimer < spawnTimerMax) {
            spawnTimer += Time.deltaTime;
        }
        else
        {
            SpawnEnemy();
            spawnTimer = 0f;
        }
    }
    private void SpawnEnemy()
    {
        GameObject enemy= GetObject();
        if(enemy != null)
        {
            enemy.transform.position = RandomSpawnPos();
            enemy.SetActive(true);
        }

    }

    private Vector2 RandomSpawnPos()
    {
       float xSpawnRange = Random.Range(spawnPos.position.x - spawnOffsetX, spawnPos.position.x + spawnOffsetY);
       float ySpawnRange = Random.Range(spawnPos.position.y - spawnOffsetX, spawnPos.position.y + spawnOffsetY);

        return new Vector2(xSpawnRange, ySpawnRange);
    }

    public void GeneratePool()
    {
        enemyPool = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < amountToSpawn; i++)
        {
            tmp = Instantiate(enemyToSpawn,holder);
            tmp.SetActive(false);
            enemyPool.Add(tmp);
        }
    }

    public GameObject GetObject()
    {
        for(int i = 0;i < amountToSpawn; i++)
        {
            if (!enemyPool[i].activeInHierarchy)
            {
                return enemyPool[i];
            }
        }
        return null;
    }
}
