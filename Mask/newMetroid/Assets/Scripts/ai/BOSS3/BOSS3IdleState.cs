using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss3IdleState : BossIstate3//Õ¾Á¢×´Ì¬
{
    private BOSS3FSM Bossmanager;
    private BossParameter3 parameter;
    private float timer;
    int modelindex;
    public Boss3IdleState(BOSS3FSM Bossmanager)
    {
        this.Bossmanager = Bossmanager;
        this.parameter = Bossmanager.parameter;
    }
    public void OnEnter()
    {
        parameter.animator.Play("Standby");
        Debug.Log("Õ¾Á¢");
        int modelindex = Random.Range(0, 3);
    }


    public void OnUpdate()
    {
        timer += Time.deltaTime;
        Bossmanager.FlipTO(parameter.target);
        
        if (timer >= parameter.idleTime)
        {
            if (modelindex==0)
            {
                Bossmanager.TransitionState(BossStateType3.BossChase);
                timer = 0;
            }
            if (modelindex == 1)
            {
                Bossmanager.TransitionState(BossStateType3.BossCharge);
                timer = 0;
            }
            if (modelindex == 2)
            {
                Bossmanager.TransitionState(BossStateType3.BossThrow);
                timer = 0;
            }
            




        }
    }
    public void OnExit()
    {

    }




}

public class Boss3ChaseState : BossIstate3//Õ¾Á¢×´Ì¬
{
    private BOSS3FSM Bossmanager;
    private BossParameter3 parameter;
    private float timer;
    public static bool up = false;
    public Boss3ChaseState(BOSS3FSM Bossmanager)
    {
        this.Bossmanager = Bossmanager;
        this.parameter = Bossmanager.parameter;
    }
    public void OnEnter()
    {
        up = true;
    }


    public void OnUpdate()
    {
        Bossmanager.TransitionState(BossStateType3.BossIdle);
    }
    public void OnExit()
    {
        up = false;
    }

    
}
public class Boss3ChargeState : BossIstate3//Õ¾Á¢×´Ì¬
{
    private BOSS3FSM Bossmanager;
    private BossParameter3 parameter;
    private float timer;
    public static bool down = false;
    public Boss3ChargeState(BOSS3FSM Bossmanager)
    {
        this.Bossmanager = Bossmanager;
        this.parameter = Bossmanager.parameter;
    }
    public void OnEnter()
    {
        down = true;
    }


    public void OnUpdate()
    {
        Bossmanager.TransitionState(BossStateType3.BossIdle);
    }
    public void OnExit()
    {
        down = false;
    }




}

public class Boss3ThrowState : BossIstate3//Õ¾Á¢×´Ì¬
{
    private BOSS3FSM Bossmanager;
    private BossParameter3 parameter;
    private float timer;
    public static bool right = false;
    public Boss3ThrowState(BOSS3FSM Bossmanager)
    {
        this.Bossmanager = Bossmanager;
        this.parameter = Bossmanager.parameter;
    }
    public void OnEnter()
    {
       right = true;
    }


    public void OnUpdate()
    {
        Bossmanager.TransitionState(BossStateType3.BossIdle);
    }
    public void OnExit()
    {
        right = false;
    }




}
//public class Boss3BossChase : BossIstate3//Õ¾Á¢×´Ì¬
//{
//    private BOSS3FSM Bossmanager;
//    private BossParameter3 parameter;
//    private float timer;
//    public Boss3BossChase(BOSS3FSM Bossmanager)
//    {
//        this.Bossmanager = Bossmanager;
//        this.parameter = Bossmanager.parameter;
//    }
//    public void OnEnter()
//    {

//    }


//    public void OnUpdate()
//    {
//        Bossmanager.FlipTO(parameter.target);
//    }
//    public void OnExit()
//    {

//    }




//}



