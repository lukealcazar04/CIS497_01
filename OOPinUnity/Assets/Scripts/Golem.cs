using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Enemy
{

    protected int damage;

    
    protected override void Awake()
    {
        base.Awake();
        health = 120;
    }

    protected override void Attack()
    {
        Debug.Log("Golem Attacks"); 
    }

    void Update()
    {
        
    }
}
