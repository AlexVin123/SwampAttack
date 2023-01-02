using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private string _label;
    [SerializeField] private int _price;
    [SerializeField] private Sprite _icon;
    [SerializeField] private bool _isByed;
    [SerializeField] protected Bullet Bullet;
    [SerializeField] private float _recharging;

    private float _timer = 0;
    private bool AbilityShoot = true;

    public string Label => _label;
    public int Price => _price;
    public Sprite Icon => _icon;
    public bool IsByed => _isByed;


    private void Update()
    {
        if (AbilityShoot == false)
        {
            if (_timer > 0)
            {
                _timer -= Time.deltaTime;
            }
            else
            {
                AbilityShoot = true;
            }
        }
    }

    public abstract void Shoot(Transform shootPoint);

    public void StartShoot(Transform shootPoint)
    {
        if (AbilityShoot == true)
        {
            Shoot(shootPoint);
            AbilityShoot = false;
            _timer = _recharging;
        }
    }

    public void Buy()
    {
        _isByed = true;
    }
}
