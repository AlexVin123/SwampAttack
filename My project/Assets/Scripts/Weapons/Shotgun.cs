using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{
    [SerializeField] private float _spread;
    [SerializeField] private int _countBullet;
    public override void Shoot(Transform shootPoint)
    {
        Vector2 upBullet = shootPoint.position;
        upBullet.y += _spread * _countBullet / 2;

        for (int i = 0; i < _countBullet; i++)
        {
            Instantiate(Bullet, upBullet, Quaternion.identity);
            upBullet.y -= _spread;
        }
    }
}
