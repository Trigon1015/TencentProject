using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootIdleState : ShootIState//Õ¾Á¢×´Ì¬
{
    private ShootFSM manager;
    private ShootParameter parameter;
    private float timer;
    public ShootIdleState(ShootFSM manager)
    {
        this.manager = manager;
        this.parameter = manager.parameter;
    }
    public void OnEnter()
    {
        Debug.Log("ZHAN");
    }


    public void OnUpdate()
    {
        if (parameter.target != null)
            manager.TransitionState(StateType.Attack );

    }



    public void OnExit()
    {
        
    }
}

public class ShootAttackState : ShootIState//Õ¾Á¢×´Ì¬
{
    private ShootFSM manager;
    private ShootParameter parameter;
    private float timer;
    public ShootAttackState(ShootFSM manager)
    {
        this.manager = manager;
        this.parameter = manager.parameter;
    }
    public void OnEnter()
    {
        //parameter.animator.Play("idle");
        Debug.Log("gj");
    }


    public void OnUpdate()
    {
        manager.transform.up = parameter.target.position - manager.transform.position;
        parameter.attackSpeed -= Time.deltaTime;
        if (parameter.attackSpeed <= 0)
        {
            parameter.shoot = true;
            parameter.attackSpeed = 3;
        }else
        {
            parameter.shoot = false;

        }
        if (parameter.target == null) 
        manager.TransitionState(StateType.Idle);

    }



    public void OnExit()
    {
        
    }
}
