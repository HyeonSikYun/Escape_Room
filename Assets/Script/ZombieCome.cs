using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieCome : MonoBehaviour
{
    [SerializeField]
    Transform transTowards; // 따라다닐 대상 선택

    [SerializeField]
    float fspeed; // 속도 조절

    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 TowardsTarget = transTowards.position - transform.position;
        rigid.velocity += TowardsTarget.normalized * fspeed * Time.deltaTime;
    }
}