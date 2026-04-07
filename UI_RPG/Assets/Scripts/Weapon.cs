using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public string wpnName;
    public abstract float GetDamage();
    
    public void SelectedWeaponName()
    {
        Debug.Log("Weapon: " + wpnName);
    }

}
