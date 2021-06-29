using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject _Bomb;
    public DroneController droneController;
    //private Transform transform;
    ///private Transform transformPos;
    public Quaternion MyGameObjectRotation;
    // Start is called before the first frame update
    void Start()
    {
        //transform = gameObject.GetComponent<Transform>();
    }

    public void DropBomb()
    {
        Instantiate(_Bomb, droneController.transform.position, MyGameObjectRotation);
        //Debug.Log("drop bomb");
    }

    public void Update()
    {
        if (_Bomb.activeSelf)
        {
            //Debug.Log("active self");
        }
    }
}
