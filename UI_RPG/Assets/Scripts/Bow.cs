using UnityEngine;

public class Bow : Weapon
{
    public float minDamage, maxDamage;
    public override float GetDamage()
    {
        return Random.Range(minDamage, maxDamage);
    }
}
