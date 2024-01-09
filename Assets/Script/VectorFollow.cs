using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorFollow : MonoBehaviour
{
    public Transform mTarget;
    float Speed = 0.5f;
    Vector3 mLookDirection;
    const float EPS = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mLookDirection = (mTarget.position - transform.position).normalized;
        if ((transform.position - mTarget.position).magnitude > EPS)
            transform.Translate(mLookDirection * Time.deltaTime * Speed);
        
    }
}
