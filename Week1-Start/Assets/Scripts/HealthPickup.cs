using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : Pickup
    //Inherits from Pickup
{
    public Pawn player;

    protected override void OnPickup(Pawn pickingUp) //overrides the parent (Pickup)
    {
        player.AddHealth(100);
        base.OnPickup(pickingUp);
    }
}
