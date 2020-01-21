using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{

    public Animator anim;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(Vector3 input)
    {
        anim.SetFloat("Horizontal", input.x * speed);
        anim.SetFloat("Vertical", input.z * speed);
        
    }

    public void Crouch(Vector3 input)
    {

        anim.SetBool("Crouch", false);
    }
}

