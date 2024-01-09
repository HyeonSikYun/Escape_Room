using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingOb : MonoBehaviour
{
    public Transform mTarget;

    float Speed = 0.3f;
    const float EPS = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(mTarget.position);
        if ((transform.position - mTarget.position).magnitude > EPS)
            transform.Translate(0.0f, 0.0f, Speed * Time.deltaTime);
    }
}
