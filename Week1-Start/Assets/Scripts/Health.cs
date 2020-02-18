using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    public int _currHealth;


    public int currentHealth
    {
        get { return _currHealth; }
        set { _currHealth = Mathf.Clamp(value, 0, maxHealth); } //Stops current health from going below 0 or above max health
    }


    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
