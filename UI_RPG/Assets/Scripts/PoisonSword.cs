using UnityEngine;

public class PoisonSword : Sword
{
    [SerializeField] float poisonDamage;
    [SerializeField] private int poisonCount;
    
    public override float GetDamage()
    {
        float baseDamage = base.GetDamage();
        if (poisonCount > 0)
        {
            poisonCount--;
            return baseDamage + poisonDamage;
        }
        return baseDamage;
    }
}
