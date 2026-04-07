using System;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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
        playerHP.text = "HP: " + player.Health.ToString("F1");
        enemyHP.text = "HP: " + enemy.Health.ToString("F1");

    }
    
    public void PlayerAttack()
    {
        player.Attack(enemy);
        enemy.Attack(player);
        UpdateUI();
    }

    public void GameOver()
    {
        GameOverUI.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
