using UnityEngine;

public class CritSword : Sword
{
    [SerializeField] private float critChance;
    [SerializeField] private float critMultiplier;
    
    public override float GetDamage()
    {
        float baseDamage = Random.Range(minDamage, maxDamage);
        float totalDamage = baseDamage;
        
        if (Random.value < critChance)
        {
            totalDamage *= critMultiplier;
            Debug.Log("CRIT!");
        }
        
        return totalDamage;
    }
}
