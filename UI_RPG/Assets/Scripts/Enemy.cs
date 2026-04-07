using UnityEngine;
using UnityEngine.UI;

public class Enemy : Character
{
    [SerializeField] private Sprite enemySprite;
    private Image enemyImg;
    [SerializeField] public float minDamage, maxDamage;
    [SerializeField] ParticleSystem deathParticles;

    void Start()
    {
        enemyImg = GameObject.Find("EnemyPortrait").GetComponent<Image>();
        enemyImg.sprite = enemySprite;
    }
    
    public override void Attack(Character toHit)
    {
        float damage = Random.Range(minDamage, maxDamage);
        toHit.TakeDamage(damage);
    }
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Death()
    {
        Debug.Log(CharName + " has been defeated!");
        EnemySpawner.Instance.SpawnEnemy();
        ParticleSystem ps = Instantiate(deathParticles, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(ps.gameObject, 2f);
    }

}
