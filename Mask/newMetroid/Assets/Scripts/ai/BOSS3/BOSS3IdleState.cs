using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss3IdleState : BossIstate3//Õ¾Á¢×´Ì¬
{
    private BOSS3FSM Bossmanager;
    private BossParameter3 parameter;
    private float timer;
    public Boss3IdleState(BOSS3FSM Bossmanager)
    {
        this.Bossmanager = Bossmanager;
        this.parameter = Bossmanager.parameter;
    }
    public void OnEnter()
    {
        parameter.animator.Play("Standby");
        Debug.Log("Õ¾Á¢");
    }


    public void OnUpdate()
    {
        Bossmanager.FlipTO(parameter.target);
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
    public Boss3ChaseState(BOSS3FSM Bossmanager)
    {
        this.Bossmanager = Bossmanager;
        this.parameter = Bossmanager.parameter;
    }
    public void OnEnter()
    {

    }


    public void OnUpdate()
    {
        Bossmanager.FlipTO(parameter.target);
    }
    public void OnExit()
    {

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



