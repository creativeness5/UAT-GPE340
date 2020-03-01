using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleWeapon : Weapons
{

    private float ammoCount;

    [SerializeField] private float bulletMovementSpeed = 100;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePosition;

    // Start is called before the first frame update
    public override void Start()
    {
        
    }

    // Update is called once per frame
    public override void Update()
    {
        
    }

    public void OnTriggerPull()
    {
        if (ammoCount > 0)
        {
            ammoCount--;
            ShootBullet();
        }
    }

    public void ShootBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as GameObject;
        BulletInfo bulletInfo = bullet.GetComponent<BulletInfo>();
        if (bulletInfo != null)
        {
            bulletInfo.damageCaused = damageCaused;
            bulletInfo.movementSpeed = bulletMovementSpeed;
        }
    }

    public void OnTriggerRelease()
    {
        //Don't do anything
    }
}
