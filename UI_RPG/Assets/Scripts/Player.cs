using Unity.VisualScripting;
using UnityEngine;

public class Player : Character
{
    [SerializeField] private Weapon[] weapons;
    [SerializeField] private Weapon activeWeapon;

    void Start()
    {
        SelectWeapon(0);
    }

    public void SelectWeapon(int index)
    {
        activeWeapon = weapons[index];
        
        for (int i = 0; i < weapons.Length; i++)
        {
            weapons[i].gameObject.SetActive(i == index);
        }
    }
    
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
