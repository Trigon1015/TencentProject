using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class IdleState : IState//վ��״̬
{
    private FSM manager;
    private Parameter parameter;
    private float timer;
    public IdleState (FSM manager)
    {
        this.manager = manager;
        this.parameter = manager.parameter;
    }
    public void OnEnter()
    {
        parameter.animator.Play("idle");
       // Debug.Log("Idle");
    }

    
   public  void OnUpdate()
    {
        timer += Time.deltaTime;
        if (parameter.target != null &&
            parameter.target.position.x >= parameter.chasePoints[0].position.x &&
            parameter.target.position.x <= parameter.chasePoints[1].position.x)//��ҽ�����Ұ���������׷��Χ��
        {
            manager.TransitionState(StateType.React);//�л�Ϊ��Ӧ״̬
        }
        if (timer >= parameter.idleTime )//վ��ʱ���㹻
        {
            manager.TransitionState(StateType.Patrol);//�л�ΪѲ��״̬
        }
        if (Physics2D.OverlapCircle(parameter.enemy.position, parameter.enemyvalue, parameter.targetLayer))//��ҽ��빥����Χ
        {

            PlayerController.hurtplayer = true;
            //if (PlayerController.hurtplayer == true)
            //{
            //    PlayerController.HurtTime += 1 * Time.deltaTime;
            //    if (PlayerController.HurtTime >= 90)
            //    {
            //        PlayerController.hurtplayer = false;
            //        PlayerController.HurtTime = 0;
            //    }
            //}
           // Debug.Log(PlayerController.hurtplayer);
        }

    }



   public  void OnExit()
    {
        timer = 0;
    }
}

public class PatrolState : IState//Ѳ��״̬
{
    private FSM manager;
    private Parameter parameter;
    private int patrolPosition;
    public PatrolState(FSM manager)
    {
        this.manager = manager;
        this.parameter = manager.parameter;
    }
    public void OnEnter()
    {
        parameter.animator.Play("walk");
       // Debug.Log("patrol");
    }


    public void OnUpdate()
    {

        manager.FlipTO(parameter.patrolPoints[patrolPosition]);
        manager.transform.position = Vector2.MoveTowards(manager.transform.position,
            parameter.patrolPoints[patrolPosition].position, parameter.moveSpeed * Time.deltaTime);
        //Debug.Log(parameter.target);
        if (parameter.target != null &&
            parameter.target.position.x >= parameter.chasePoints[0].position.x &&
            parameter.target.position.x <= parameter.chasePoints[1].position.x)//��ҽ�����Ұ������Ѳ�߷�Χ��
        {
            manager.TransitionState(StateType.React);//��Ϊ��Ӧ״̬
        }
        if (Vector2 .Distance (manager.transform.position,parameter.patrolPoints[patrolPosition].position)<.1f)//����Ѳ�ߵ�
        {
            manager.TransitionState(StateType.Idle );//��Ϊվ��
        }
        if (Physics2D.OverlapCircle(parameter.enemy.position, parameter.enemyvalue, parameter.targetLayer))//��ҽ��빥����Χ
        {

            PlayerController.hurtplayer = true;
            //if (PlayerController.hurtplayer == true)
            //{
            //    PlayerController.HurtTime += 1 * Time.deltaTime;
            //    if (PlayerController.HurtTime >= 90)
            //    {
            //        PlayerController.hurtplayer = false;
            //        PlayerController.HurtTime = 0;
            //    }
            //}
            //Debug.Log(PlayerController.hurtplayer);
        }
    }



    public void OnExit()
    {
        patrolPosition++;
        if (patrolPosition >=parameter .patrolPoints .Length )//��Ѳ�ߵ�֮���ƶ�
        {
            patrolPosition = 0;
        }
    }
}

public class ChaseState : IState
{
    private FSM manager;
    private Parameter parameter;
    public ChaseState(FSM manager)
    {
        this.manager = manager;
        this.parameter = manager.parameter;
      
    }
    public void OnEnter()
    {
        parameter.animator.Play("walk");
        //Debug.Log("chase");
       
    }


    public void OnUpdate()
    {
        manager.FlipTO(parameter.target);
        if (parameter.target)
        {
           
            manager.transform.position = Vector2.MoveTowards(manager.transform.position,
              parameter.target.position, parameter.chaseSpeed * Time.deltaTime);//׷�����
        }
        
        if (parameter.target == null ||
            manager.transform.position.x < parameter.chasePoints[0].position.x ||
            manager.transform.position.x > parameter.chasePoints[1].position.x)
        {
            manager.TransitionState(StateType.Idle);
        }
        if (Physics2D.OverlapCircle(parameter.attackPoint.position, parameter.attackArea, parameter.targetLayer))//��ҽ��빥����Χ
        {
            
          manager.TransitionState(StateType.Attack);

        }
        if (Physics2D.OverlapCircle(parameter.enemy .position, parameter.enemyvalue , parameter.targetLayer))//��ҽ��빥����Χ
        {

            PlayerController.hurtplayer = true;
            //if (PlayerController.hurtplayer == true)
            //{
            //    PlayerController.HurtTime += 1 * Time.deltaTime;
            //    if (PlayerController.HurtTime >= 90)
            //    {
            //        PlayerController.hurtplayer = false;
            //        PlayerController.HurtTime = 0;
            //    }
            //}
           // Debug.Log(PlayerController.hurtplayer);
        }
    }



    public void OnExit()
    {

    }
}

public class ReactState : IState
{
    private FSM manager;
    private Parameter parameter;

    private AnimatorStateInfo info;
    public ReactState(FSM manager)
    {
        this.manager = manager;
        this.parameter = manager.parameter;
    }
    public void OnEnter()
    {
        parameter.animator.Play("walk");
        //Debug.Log("react");
    }

    public void OnUpdate()
    {
        info = parameter.animator.GetCurrentAnimatorStateInfo(0);

        
        if (info.normalizedTime >= 3.95f)//���￴����Һ�ķ�Ӧʱ��
        {
            manager.TransitionState(StateType.Chase);
        }
        if (Physics2D.OverlapCircle(parameter.enemy.position, parameter.enemyvalue, parameter.targetLayer))//��ҽ��빥����Χ
        {

            PlayerController.hurtplayer = true;
            //if (PlayerController.hurtplayer == true)
            //{
            //    PlayerController.HurtTime += 1 * Time.deltaTime;
            //    if (PlayerController.HurtTime >= 90)
            //    {
            //        PlayerController.hurtplayer = false;
            //        PlayerController.HurtTime = 0;
            //    }
            //}
            //Debug.Log(PlayerController.hurtplayer);
        }
    }

    public void OnExit()
    {

    }
}
public class AttackState : IState
{
    private FSM manager;
    private Parameter parameter;

    private AnimatorStateInfo info;
    public AttackState(FSM manager)
    {
        this.manager = manager;
        this.parameter = manager.parameter;
    }
    public void OnEnter()
    {
        parameter.animator.Play("attack");
        //Debug.Log("attack");
    }

    public void OnUpdate()
    {
        info = parameter.animator.GetCurrentAnimatorStateInfo(0);
       
        if (info.normalizedTime >= 3.95f)//���Ź�������ʱ�䳬��3.95��ת��Ϊ׷��״̬
        {
            manager.TransitionState(StateType.Chase);
        }
        if (Physics2D.OverlapCircle(parameter.enemy.position, parameter.enemyvalue, parameter.targetLayer))//��ҽ��빥����Χ
        {

            PlayerController.hurtplayer = true;
            if (PlayerController.hurtplayer == true)
            {
                //PlayerController.HurtTime += 1 * Time.deltaTime;
                //Debug.Log(PlayerController.HurtTime);
                //if (PlayerController.HurtTime >= 3)
                //{
                //    PlayerController.hurtplayer = false;
                //    Debug.Log(PlayerController.hurtplayer);
                //    PlayerController.HurtTime = 0;
                //}
            }
          // Debug.Log(PlayerController.hurtplayer);
        }
    }

    public void OnExit()
    {
      
    }
}


