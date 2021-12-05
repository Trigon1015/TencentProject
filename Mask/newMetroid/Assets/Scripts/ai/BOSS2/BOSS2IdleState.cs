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

public class Boss2BossChase : BossIstate2//Õ¾Á¢×´Ì¬
{
    private BOSS2FSM Bossmanager;
    private BossParameter2 parameter;
    private float timer;
    public Boss2BossChase(BOSS2FSM Bossmanager)
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
//public class Boss2BossChase : BossIstate2//Õ¾Á¢×´Ì¬
//{
//    private BOSS2FSM Bossmanager;
//    private BossParameter2 parameter;
//    private float timer;
//    public Boss2BossChase(BOSS2FSM Bossmanager)
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


