using UnityEngine;

public class InfectionEnemy : Enemy
{
    [SerializeField] float infectionDamage;
    [SerializeField] private int infectionCount;
    
    

    public override void Attack(Character toHit)
    {
        float baseDamage = Random.Range(minDamage, maxDamage);

        float totalDamage = baseDamage;

        if (infectionCount > 0)
        {
            float currentPoison = infectionDamage;

            totalDamage += currentPoison;

            infectionCount--;
        }

        toHit.TakeDamage(totalDamage);
    }
}
