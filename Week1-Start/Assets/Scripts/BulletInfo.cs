using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInfo : MonoBehaviour
{
    public float damageCaused;
    public float movementSpeed; //different weapons can fire at different times
    [SerializeField] private float lifeSpan = 1.5f;


    public void Start()
    {
        Destroy(gameObject, lifeSpan); //if bullet doesn't hit anything/lasts past life span then destroy
    }

    public void Update()
    {
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
    }

    public void OnTriggerEnter(Collider other)
    {
        Health otherHealth = other.gameObject.GetComponent<Health>();
        if (otherHealth != null)
        {
            //otherHealth.TakeDamage(damageCaused);
        }

        Destroy(gameObject);
    }


}
