using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager singleton;
    public ScoreManager scoreManager;
    [SerializeField] private Transform[] SpawnPoints;
    [SerializeField] private Enemy enemyPrefab;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void Awake()
    {
        singleton = this;
    }

    public void EndGame()
    {
        StopAllCoroutines();
        scoreManager.RegisterHighScore();
        
        
    }
    IEnumerator SpawnEnemy()
    {
        while (true)
        { 

        yield return new WaitForSeconds(1f);
        int randomIndex= Random.Range(0, SpawnPoints.Length);
        Transform randomSpawnPoint= SpawnPoints[randomIndex];

        Enemy enemy = Instantiate (enemyPrefab, randomSpawnPoint.position, Quaternion.identity);
        enemy.SetUpEnemy(3);
        
        }

       
        

    }
}
