using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullWeapon : MonoBehaviour
{
    [SerializeField] private Weapon[] _weapons;
    [SerializeField] private Weapon _startWeapon;

    private Weapon[] WeaponsOnScene;

    private void Awake()
    {
        WeaponsOnScene = new Weapon[_weapons.Length];

        for (int i = 0; i < _weapons.Length; i++)
        {
            Instantiate(_weapons[i]);
        }

        WeaponsOnScene = GameObject.FindObjectsOfType<Weapon>();

        for (int i = 0; i < WeaponsOnScene.Length; i++)
        {
            WeaponsOnScene[i].gameObject.SetActive(false);
        }
    }

    public Weapon GiveStartWeapon()
    {
        foreach (Weapon weapon in WeaponsOnScene)
        {
            if(weapon.GetType().Name == _startWeapon.GetType().Name)
            {
                return weapon;
            }
        }

        return null;
    }

    public Weapon[] SetWeaponsInShop()
    {
        Weapon[] weapons = new Weapon[WeaponsOnScene.Length - 1];
        int countWeaponForBuy = 0;

        for (int i = 0; i < WeaponsOnScene.Length; i++)
        {    
            if(WeaponsOnScene[i].GetType() != _startWeapon.GetType())
            {
                weapons[countWeaponForBuy] = WeaponsOnScene[i];
                countWeaponForBuy++;
            }
        }

        return weapons;
    }
}
