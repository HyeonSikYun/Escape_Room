using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
    // Start is called before the first frame update
    public static float DistanceFromTarget;
    public float ToTarget;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit Hit;
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out Hit))
        {
            ToTarget = Hit.distance;
            DistanceFromTarget = ToTarget;
        }

        
    }
}
