using Unity.VisualScripting;
using UnityEngine;

public class Player : Character
{
    [SerializeField] private Weapon activeWeapon;
    public override void Attack(Character toHit)
    {
        toHit.TakeDamage(activeWeapon);
        //float damage = activeWeapon.GetDamage();
        //toHit.TakeDamage(damage);
        
    }

    public override void Death()
    {
        Debug.Log(CharName + " died! Game Over!");
        GameManager.Instance.GameOver();
        
    }
    
}
