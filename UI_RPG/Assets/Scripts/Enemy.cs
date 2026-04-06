using UnityEngine;

public class Enemy : Character
{

    [SerializeField] public float minDamage, maxDamage;
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
        Destroy(gameObject);
    }

}
