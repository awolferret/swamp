using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : Weapon
{
    public override void Shoot(Transform shootPoint)
    {
        int minBullets = 3;
        int maxBullets = 6;

        for (int i = 0; i < Random.Range(minBullets,maxBullets); i++)
        {
            float minRange = -0.5f;
            float maxRange = 0.5f;
            Vector2 RandomPosition = new Vector2(shootPoint.position.x, shootPoint.position.y + Random.Range(minRange, maxRange));
            Instantiate(Bullet, RandomPosition, Quaternion.identity);
        }
    }
}