using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{
    [SerializeField] private int _bulletInShoot = 3;
    private float range = 0.2f;

    public override void Shoot(Transform shootPoint)
    {
        for (int i = 0; i < _bulletInShoot; i++)
        {
            Vector3 currentShootPoint = shootPoint.position;
            currentShootPoint.y += Random.Range(-range, range);
            Instantiate(Bullet, currentShootPoint, Quaternion.identity);
        }
    }
}
