using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField]private string charName;

    public float Health
    {
        get { return health; }
        set { health = Mathf.Max(0, value); }
    }
    
    public string CharName
    {
        get { return charName; }
    }

    public abstract void Attack(Character toHit);

    public void TakeDamage(float damage)
    {
        Health = health - damage;
        Debug.Log(charName + " took " + damage + " damage! Health: " + health);
        if (health <= 0)
        {
            Death();
        }
    }

    public void TakeDamage(Weapon thrownWeapon)
    {
        float damage = thrownWeapon.GetDamage();
        TakeDamage(damage);
    }

    public abstract void Death();
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
