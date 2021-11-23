using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyIdleState : FlyIState//վ��״̬
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
        Debug.Log("վ��");

    }


    public void OnUpdate()
    {
        if (parameter.target != null )//��ҽ�����Ұ���������׷��Χ��
        {
            manager.TransitionState(FlyStateType.Chase);//�л�Ϊ׷��״̬
        }

    }



    public void OnExit()
    {
       
    }
}
public class FlyChaseState : FlyIState//׷��״̬
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
        Debug.Log("׷��");
    }


    public void OnUpdate()
    {
        manager.FlipTO(parameter.target);
        manager.transform.up = parameter.target.position - manager.transform.position;
        manager.transform.position = Vector2.MoveTowards(manager.transform.position,
    parameter.target.position, parameter.chaseSpeed * Time.deltaTime);//׷�����
    }



    public void OnExit()
    {

    }
}
public class FlyAttackState : FlyIState//����״̬
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