using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2IdleState : BossIstate2//վ��״̬
{
    private BOSS2FSM Bossmanager;
    private BossParameter2 parameter;
    private float timer;
    public Boss2IdleState(BOSS2FSM Bossmanager)
    {
        this.Bossmanager = Bossmanager;
        this.parameter = Bossmanager.parameter;
    }
    public void OnEnter()
    {
        parameter.animator.Play("STANDBY");
        Debug.Log("վ��");
    }


    public void OnUpdate()
    {
        if(parameter .health <=0)
        {
            death .dead =true;
        }
        timer += Time.deltaTime;
        Bossmanager.FlipTO(parameter.target);
        //int modelindex = Random.Range(0, 4);
        //int modelindex =2;
        if (timer >= parameter.idleTime)
        {
            Bossmanager.TransitionState(BossStateType2.BossChase);
            timer = 0;
           


        }
    }
    public void OnExit()
    {

    }




}

public class Boss2ChaseState : BossIstate2//�ƶ�״̬
{
    private BOSS2FSM Bossmanager;
    private BossParameter2 parameter;
    private float timer;
    public static int enemy=0;
    public static int change=0 ;
    public bool active=true;
    public bool active2 = true;
    public bool active3 = true;
    public static float hp=10;
    public Boss2ChaseState(BOSS2FSM Bossmanager)
    {
        this.Bossmanager = Bossmanager;
        this.parameter = Bossmanager.parameter;
    }
    public void OnEnter()
    {
        parameter.animator.Play("MOVE");
        Debug.Log("�ƶ�");
    }


    public void OnUpdate()
    {
        hp = parameter.health; 
        Debug.Log(enemy);
        Debug.Log(change );
        if (parameter.health <= 0)
        {
            death.dead = true;
        }
        if (parameter.health <10&& active==true)
        {active = false;
            enemy = 1;
            change = 1;
            Bossmanager.TransitionState(BossStateType2.enemy);
            

        }
        if (parameter.health < 6 && active2 == true)
        {active2 = false;
            enemy = 2;
            change = 2;
            Bossmanager.TransitionState(BossStateType2.enemy);
            
        }
        if (parameter.health < 2 && active3 == true)
        {active3 = false;
            enemy = 3;
            change = 3;
            Bossmanager.TransitionState(BossStateType2.enemy);
            
        }
        


        timer += Time.deltaTime;
        Bossmanager.FlipTO(parameter.target);

        if (timer <= 5)
        {
            //manager.transform.up = parameter.target.position - manager.transform.position;
            Bossmanager.transform.position = Vector2.MoveTowards(Bossmanager.transform.position,
        parameter.target.position, parameter.chaseSpeed * Time.deltaTime);//׷�����
        }
        
        if (timer > 2)
        {
            Bossmanager.TransitionState(BossStateType2.BossCharge);
            timer = 0;
        }
    }
    public void OnExit()
    {
        Boss2ThrowState.nail = false;
        Boss2NailState.pail = false;
        enemy = 0;
    }




}

public class Boss2ChargeState : BossIstate2//�ж�״̬
{
    private BOSS2FSM Bossmanager;
    private BossParameter2 parameter;
    private float timer;
    int modelindex;
    public Boss2ChargeState(BOSS2FSM Bossmanager)
    {
        this.Bossmanager = Bossmanager;
        this.parameter = Bossmanager.parameter;
    }
    public void OnEnter()
    {
         modelindex = Random.Range(0, 2);
        Debug.Log("�ж�");
    }


    public void OnUpdate()
    {
        if (parameter.health <= 0)
        {
            death.dead = true;
        }
        if (modelindex==0)
        {
            Bossmanager.TransitionState(BossStateType2.BossThrow);
        }
        if (modelindex == 1)
        {
            Bossmanager.TransitionState(BossStateType2.nail);
        }
    }
    public void OnExit()
    {

    }




}


public class Boss2ThrowState : BossIstate2//ˮͰ״̬
{
    private BOSS2FSM Bossmanager;
    private BossParameter2 parameter;
    private float timer;
    private AnimatorStateInfo time;
    public static bool nail=false ;
    public Boss2ThrowState(BOSS2FSM Bossmanager)
    {
        this.Bossmanager = Bossmanager;
        this.parameter = Bossmanager.parameter;
    }
    public void OnEnter()
    {
        parameter.animator.Play("ATTACK1");
        Debug.Log("ˮͰ");
    }


    public void OnUpdate()
    {
        if (parameter.health <= 0)
        {
            death.dead = true;
        }
        time = parameter .animator .GetCurrentAnimatorStateInfo(0);
        Bossmanager.FlipTO(parameter.target);
        if(time.normalizedTime >= .999)
        {
            nail = true;
            Bossmanager.TransitionState(BossStateType2.BossChase);
        }
    }
    public void OnExit()
    {
       
    }




}

public class Boss2NailState : BossIstate2//ͼ��״̬
{
    private BOSS2FSM Bossmanager;
    private BossParameter2 parameter;
    private float timer;
    public static bool pail=false ;
    private AnimatorStateInfo time;
    public Boss2NailState(BOSS2FSM Bossmanager)
    {
        this.Bossmanager = Bossmanager;
        this.parameter = Bossmanager.parameter;
    }
    public void OnEnter()
    {
        parameter.animator.Play("ATTACK2");
        Debug.Log("ͼ��");
    }


    public void OnUpdate()
    {
        if (parameter.health <= 0)
        {
            death.dead = true;
        }
        time = parameter.animator.GetCurrentAnimatorStateInfo(0);
        Bossmanager.FlipTO(parameter.target);
        if (time.normalizedTime >= .999)
        {
            pail = true;
            Debug.Log(pail);
            Bossmanager.TransitionState(BossStateType2.BossChase);
        }
    }
    public void OnExit()
    {
        
    }




}


public class Boss2EnemyState : BossIstate2//�ٻ�״̬
{
    private BOSS2FSM Bossmanager;
    private BossParameter2 parameter;
    private float timer;
    public static int back=3;
    public Boss2EnemyState(BOSS2FSM Bossmanager)
    {
        this.Bossmanager = Bossmanager;
        this.parameter = Bossmanager.parameter;
    }
    public void OnEnter()
    {
        parameter.animator.Play("ATTACK3");
        Debug.Log("�ٻ�");
    }


    public void OnUpdate()
    {
        if (GameObject.FindGameObjectWithTag("bossenemy") == null)
        {
            back ++;
            Bossmanager.TransitionState(BossStateType2.BossChase);
        }
        if (parameter.health <= 0)
        {
            death.dead = true;
        }
        Bossmanager.FlipTO(parameter.target);
    }
    public void OnExit()
    {

    }




}



