using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{
    public int EnemyHealth = 10;
    public GameObject TheEnemy;
    public int StatusCheck;
    // Start is called before the first frame update
    void DamageZombie (int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyHealth <= 0 && StatusCheck == 0)
        {
            StatusCheck = 2;
            TheEnemy.GetComponent<Animation>().Stop("idle");
            TheEnemy.GetComponent<Animation>().Play("fallingback");
        }
        
    }
}
