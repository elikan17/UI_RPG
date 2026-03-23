using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Enemy enemy;
    [SerializeField] private TMP_Text playerName, playerHP, enemyName, enemyHP;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateUI();
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

// Update is called once per frame
    void Update()
    {
        
    }
}
