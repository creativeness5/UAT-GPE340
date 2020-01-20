using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))] //requires camera in scene, if no camera it will spawn one

public class CameraController : MonoBehaviour
{

    public Transform target; //need transform.position instead of just one point
    public float targetRotateSpeed;
    private Camera mainCamera;

    public Pawn pawn;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        RotateToMousePosition(); 
        //mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position, target.position, pawn.speed);
    }

    void RotateToMousePosition()
    {
        //define the plane that the player is on
        Plane groundPlane;
        groundPlane = new Plane(Vector3.up, target.position);
        //used Vector3 for world rather than local

        float distance;
        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);


        groundPlane.Raycast(cameraRay, out distance);


        if (groundPlane.Raycast(cameraRay, out distance))
        {
            Vector3 intersectionPoint = cameraRay.GetPoint(distance); //find the world point of the intersection

           

            Quaternion targetRotation; //Don't need to know other than it helps rotate
            Vector3 lookVector = intersectionPoint - target.position;  //target - start
            targetRotation = Quaternion.LookRotation(lookVector, Vector3.up); //don't ask me to explain the math
            
            target.rotation = Quaternion.RotateTowards(target.rotation, targetRotation, targetRotateSpeed * Time.deltaTime); //rotate player to that point; makes it frames per second rather than per frame draw

        }

        

    }
}
