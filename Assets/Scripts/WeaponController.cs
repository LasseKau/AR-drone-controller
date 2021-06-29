using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject _Bomb;

    public DroneController droneController;
    // The target marker.
    ///public float speed = 1.0f;

    //public Quaternion MyGameObjectRotation;

    public void DropBomb()
    {
        //// Determine which direction to rotate towards
        //Vector3 targetDirection = new Vector3(180.0f, 0, 0);

        //// The step size is equal to speed times frame time.
        //float singleStep = speed * Time.deltaTime;

        //// Rotate the forward vector towards the target direction by one step
        //Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);

        //// Draw a ray pointing at our target in
        //Debug.DrawRay(transform.position, newDirection, Color.red);

        Instantiate(_Bomb, droneController.transform.position, transform.rotation);

        Debug.Log("drop bomb");
    }

}