using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Pawn pawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Pass inputs onto the pawn
        pawn.Move(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")));

        if (Input.GetKey(KeyCode.LeftControl))
        {
            pawn.Crouch(true);

            pawn.capscol_top.enabled = false;
        }

        else
        {
            pawn.Crouch(false);

            pawn.capscol_top.enabled = true;
        }
    }
}
