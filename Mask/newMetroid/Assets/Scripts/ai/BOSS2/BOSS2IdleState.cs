using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2IdleState : BossIstate2//Õ¾Á¢×´Ì¬
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
        Debug.Log("Õ¾Á¢");
    }


    public void OnUpdate()
    {
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

public class Boss2ChaseState : BossIstate2//ÒÆ¶¯×´Ì¬
{
    private BOSS2FSM Bossmanager;
    private BossParameter2 parameter;
    private float timer;
    public static int enemy=0;
    public Boss2ChaseState(BOSS2FSM Bossmanager)
    {
        this.Bossmanager = Bossmanager;
        this.parameter = Bossmanager.parameter;
    }
    public void OnEnter()
    {
        parameter.animator.Play("MOVE");
        Debug.Log("ÒÆ¶¯");
    }


    public void OnUpdate()
    {
        if (parameter.health <10)
        {
            enemy = 1;
        }
        if (parameter.health < 6)
        {
            enemy = 2;
        }
        if (parameter.health < 2)
        {
            enemy = 3;
        }

        timer += Time.deltaTime;
        Bossmanager.FlipTO(parameter.target);

        if (timer <= 5)
        {
            //manager.transform.up = parameter.target.position - manager.transform.position;
            Bossmanager.transform.position = Vector2.MoveTowards(Bossmanager.transform.position,
        parameter.target.position, parameter.chaseSpeed * Time.deltaTime);//×·»÷Íæ¼Ò
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

public class Boss2ChargeState : BossIstate2//ÅÐ¶Ï×´Ì¬
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
        Debug.Log("ÅÐ¶Ï");
    }


    public void OnUpdate()
    {
        if(modelindex==0)
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


public class Boss2ThrowState : BossIstate2//Ë®Í°×´Ì¬
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
        Debug.Log("Ë®Í°");
    }


    public void OnUpdate()
    {
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

public class Boss2NailState : BossIstate2//Í¼¶¤×´Ì¬
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
        Debug.Log("Í¼¶¤");
    }


    public void OnUpdate()
    {
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


public class Boss2EnemyState : BossIstate2//ÕÙ»½×´Ì¬
{
    private BOSS2FSM Bossmanager;
    private BossParameter2 parameter;
    private float timer;
    public Boss2EnemyState(BOSS2FSM Bossmanager)
    {
        this.Bossmanager = Bossmanager;
        this.parameter = Bossmanager.parameter;
    }
    public void OnEnter()
    {
        parameter.animator.Play("ATTACK3");
        Debug.Log("ÕÙ»½");
    }


    public void OnUpdate()
    {
        Bossmanager.FlipTO(parameter.target);
    }
    public void OnExit()
    {

    }




}



