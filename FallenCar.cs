using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenCar : MonoBehaviour
{
    public GameObject car;
    public GameObject cube;

    private void OnCollisionEnter(Collision collision) 
    {

        if(collision.gameObject == cube)
        {
           car.transform.position = Vector3.zero;
            car.transform.rotation = Quaternion.identity;
        }
    }

}
