using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private Player player;
    [SerializeField] private Enemy enemy;
    [SerializeField] private TMP_Text playerName, playerHP, enemyName, enemyHP;
    
    public GameObject GameOverUI;
    
    void Start()
    {
        UpdateUI();
        Instance = this;
    }

    private void UpdateUI()
    {
        playerName.text = "Player " + player.CharName;
        enemyName.text = "Enemy " + enemy.CharName;
        playerHP.text = "HP: " + player.health.ToString("F1");
        enemyHP.text = "HP: " + enemy.health.ToString("F1");

    }
    
    public void PlayerAttack()
    {
        player.Attack(enemy);
        enemy.Attack(player);
        UpdateUI();
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        GameOverUI.SetActive(true);
    }
    
    public void SetCurrentEnemy(Enemy newEnemy)
    {
        enemy = newEnemy;
    }
    
// Update is called once per frame
    void Update()
    {
        
    }
}
