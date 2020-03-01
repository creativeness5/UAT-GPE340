using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapons : MonoBehaviour
{
    [SerializeField] protected float damageCaused; //allows for the children to be able to access this
    public Transform RighthandPosition;
    public Transform LefthandPosition;

    // Start is called before the first frame update
    public abstract void Start();


    // Update is called once per frame
    public abstract void Update();
   
}
