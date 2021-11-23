using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyIdleState : FlyIState//Õ¾Á¢×´Ì¬
{
    private FlyFSM manager;
    private FlyParameter parameter;
    private float timer;
    public FlyIdleState(FlyFSM manager)
    {
        this.manager = manager;
        this.parameter = manager.parameter;
    }
    public void OnEnter()
    {
        parameter.animator.Play("idle");
        Debug.Log("Õ¾Á¢");

    }


    public void OnUpdate()
    {
        if (parameter.target != null )//Íæ¼Ò½øÈëÊÓÒ°²¢ÇÒÍæ¼ÒÔÚ×·Öð·¶Î§ÄÚ
        {
            manager.TransitionState(FlyStateType.Chase);//ÇÐ»»Îª×·Öð×´Ì¬
        }

    }



    public void OnExit()
    {
       
    }
}
public class FlyChaseState : FlyIState//×·Öð×´Ì¬
{
    private FlyFSM manager;
    private FlyParameter parameter;
    private float timer;
    public FlyChaseState(FlyFSM manager)
    {
        this.manager = manager;
        this.parameter = manager.parameter;
    }
    public void OnEnter()
    {
        Debug.Log("×·Öð");
    }


    public void OnUpdate()
    {
        manager.FlipTO(parameter.target);
        manager.transform.up = parameter.target.position - manager.transform.position;
        manager.transform.position = Vector2.MoveTowards(manager.transform.position,
    parameter.target.position, parameter.chaseSpeed * Time.deltaTime);//×·»÷Íæ¼Ò
    }



    public void OnExit()
    {

    }
}
public class FlyAttackState : FlyIState//¹¥»÷×´Ì¬
{
    private FlyFSM manager;
    private FlyParameter parameter;
    private float timer;
    public FlyAttackState(FlyFSM manager)
    {
        this.manager = manager;
        this.parameter = manager.parameter;
    }
    public void OnEnter()
    {

    }


    public void OnUpdate()
    {


    }



    public void OnExit()
    {

    }
}