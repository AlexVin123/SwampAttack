using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private List<Weapon> _weapons;
    [SerializeField] private Player _player;
    [SerializeField] private WeaponView _tamplate;
    [SerializeField] private GameObject _itemConteiner;

    private void Start()
    {
        for(int i = 0; i < _weapons.Count; i++)
        {
            AddItem(_weapons[i]);
        }
        
    }

    private void AddItem(Weapon weapon)
    {
        var view = Instantiate(_tamplate, _itemConteiner.transform);

        view.Render(weapon);
    }
}
