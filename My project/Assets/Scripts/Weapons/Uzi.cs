using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uzi : Weapon
{
    [SerializeField] private int _countShoot;
    [SerializeField] private float _timeBetweenShots;

    private void Update()
    {
        
    }
    public override void Shoot(Transform shootPoint)
    {
        StartCoroutine(Shots(shootPoint));
    }

    private  IEnumerator Shots(Transform shootPoint)
    {
        for (int i = 0; i < _countShoot; i++)
        {
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);
            yield return new WaitForSeconds(_timeBetweenShots);
        }
        
    }
}
