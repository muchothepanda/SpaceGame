using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager singleton;
    public ScoreManager scoreManager;
    [SerializeField] private Transform[] SpawnPoints;
    [SerializeField] private Enemy[] enemyPrefab;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
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
            int randomEnemy=Random.Range(0, enemyPrefab.Length);
            Transform randomSpawnPoint= SpawnPoints[randomIndex];

            Enemy enemy = Instantiate(enemyPrefab[randomEnemy], randomSpawnPoint.position, Quaternion.identity);
            enemy.SetUpEnemy(3);
        }
    }
}
