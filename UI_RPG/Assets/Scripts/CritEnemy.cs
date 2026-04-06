using UnityEngine;

public class CritEnemy : Enemy
{
    [SerializeField] private float critChance;
    [SerializeField] private float critMultiplier;
    
    public override void Attack(Character toHit)
    {
        float baseDamage = Random.Range(minDamage, maxDamage);
        float totalDamage = baseDamage;
        
        if (Random.value < critChance)
        {
            totalDamage *= critMultiplier;
            Debug.Log("CRIT!");
        }
        
        toHit.TakeDamage(totalDamage);
    }
}
