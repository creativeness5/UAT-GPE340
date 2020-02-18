using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //protected - allows for children to access but not anything outside of this script
    protected virtual void OnPickup (Pawn pickingUp) 
    {
        Debug.Log(gameObject.name + " was picked up.");
    }

    private void OnTriggerEnter(Collider other)
    {
        Pawn otherPawn = other.GetComponent<Pawn>();
        if (otherPawn != null)
        {
            //OnPickup(pickingUp);
            Destroy(gameObject);
        }
    }


}
