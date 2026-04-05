using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static EnemySpawner Instance;
    public GameObject[] enemies;
    public GameManager gameManager;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instance = this;
    }

    public void SpawnEnemy()
    {
        int index = Random.Range(0, enemies.Length);
        GameObject spawned = Instantiate(enemies[index], transform.position, Quaternion.identity);
        
        Enemy enemyComponent = spawned.GetComponent<Enemy>();
        
        if (gameManager != null)
        {
            gameManager.SetCurrentEnemy(enemyComponent);
        }
    }
}
