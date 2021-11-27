using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class BossIdleState : BossIState//Õ¾Á¢×´Ì¬
{
    private BOSSFSM Bossmanager;
    private BossParameter parameter;
    private float timer;
    public BossIdleState(BOSSFSM Bossmanager)
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
        
        timer += Time.deltaTime;
        Bossmanager.FlipTO(parameter.target);
        //int modelindex = Random.Range(0, 4);
        //int modelindex =2;
        if (timer >= parameter.idleTime)
        {
            Bossmanager.TransitionState(BossStateType.BossChase);
            timer = 0;
            if (BossShield1.Boss2 == true)
            {
                Bossmanager.TransitionState(BossStateType.BossCharge);
            }
            //if (modelindex==0)
            //{
            //    Bossmanager.TransitionState(BossStateType.BossIdle);
            //    Debug.Log("Õ¾Á¢");
            //}
            //if (modelindex ==1)
            //{
            //    Bossmanager.TransitionState(BossStateType.BossChase);
            //    Debug.Log("×·»÷");
            //}
            //if (modelindex == 2)
            //{
            //    Bossmanager.TransitionState(BossStateType.BossCharge);
            //    Debug.Log("³å·æ");
            //}
            //if (modelindex ==3)
            //{
            //    Bossmanager.TransitionState(BossStateType.BossCharge);
            //    Debug.Log("Í¶ÖÀ");
            //}



        }

            
            

            

       
            

           
       

    }
    public void OnExit()
    {
       
    }




}
   
    

   



public class BossChaseState : BossIState
{
    public bool chase = true;
    private BOSSFSM Bossmanager;
    private BossParameter parameter;
    private float timer = 0;
    

    

    public BossChaseState(BOSSFSM manager)
    {
        this.Bossmanager = manager;
        this.parameter = manager.parameter;
        
    }
    
    public void OnEnter()
    {
        parameter.animator.Play("walk");

    }


    public void OnUpdate()
    {
        if (BossShield1.Boss2 == true)
        {
            Bossmanager.TransitionState(BossStateType.BossCharge);
        }
        timer += Time.deltaTime;
        Bossmanager.FlipTO(parameter.target);
        
        if (timer<=10)
        {
            //manager.transform.up = parameter.target.position - manager.transform.position;
            Bossmanager.transform.position = Vector2.MoveTowards(Bossmanager.transform.position,
        parameter.target.position, parameter.chaseSpeed * Time.deltaTime);//×·»÷Íæ¼Ò
        }
        if (Physics2D.OverlapCircle(parameter.attackPoint.position, parameter.attackArea, parameter.targetLayer))//Íæ¼Ò½øÈë¹¥»÷·¶Î§
        {

            Bossmanager.TransitionState(BossStateType.BossThrow );

        }
        if (timer>10)
        {
            Bossmanager.TransitionState(BossStateType.BossThrow);
            timer = 0;
        }
       
        
    }

    
    public void OnExit()
    {
        
    }
}

public class BossChargeState : BossIState
{
    private BOSSFSM Bossmanager;
    private BossParameter parameter;
    private float timer = 0;
    private bool right;
    public float jumptime = 0;
    public int  modelindex = 0;
    public BossChargeState(BOSSFSM Bossmanager)
    {
        this.Bossmanager = Bossmanager;
        this.parameter = Bossmanager.parameter;
    }
    public void OnEnter()
    {
        parameter.animator.Play("Charge");
        //int modelindex = Random.Range(0, 3);
        //if (modelindex == 0)
        //{
        //    Bossmanager.transform.position = new Vector3(11, -3, 0);
        //}
        //if (modelindex == 1)
        //{
        //    Bossmanager.transform.position = new Vector3(11, 0, 0);
        //}
        //if (modelindex == 2)
        //{
        //    Bossmanager.transform.position = new Vector3(11, 3, 0);
        //}

    }

    

    public void OnUpdate()
    {
        Bossmanager.FlipTO(parameter.target);
        if(parameter .health <=20)
        { jumptime += Time.deltaTime;
            if (jumptime >2&&BOSSFSM .right ==true)
            {
                parameter.rb.velocity  = new Vector2(6, 12);
                jumptime = 0;
                 
            }
            if (jumptime > 2 && BOSSFSM.right == false)
            {
                parameter.rb.velocity = new Vector2(-6, 12);
                jumptime = 0;
                 
            }

            Bossmanager.transform.position = Vector2.MoveTowards(Bossmanager.transform.position,
        parameter.target.position, parameter.chaseSpeed * Time.deltaTime);

        }
           
        
        if(parameter .health >=20)
        {
            timer += Time.deltaTime;


            if (timer <= 1.25 && right == true)
            {
                Bossmanager.transform.position = Bossmanager.transform.position + new Vector3(parameter.chargeSpeed * Time.deltaTime, 0, 0);
            }
            if (timer <= 1.25 && right == false)
            {
                Bossmanager.transform.position = Bossmanager.transform.position - new Vector3(parameter.chargeSpeed * Time.deltaTime, 0, 0);
            }
            if (timer > 1.25)
            {
                Bossmanager.TransitionState(BossStateType.BossIdle);
                timer = 0;
                right = BOSSFSM.right;

            }

        }
              
            
       
        
    }

    public void OnExit()
    {
        
       
    }
}

public class BossThrowState : BossIState
{
    private BOSSFSM Bossmanager;
    private BossParameter parameter;
    public static bool attack;
    private float timer=0;

    public BossThrowState(BOSSFSM Bossmanager)
    {
        this.Bossmanager = Bossmanager;
        this.parameter = Bossmanager.parameter;
    }
    public void OnEnter()
    {
        parameter.animator.Play("attack");
        attack = true;
    }


    public void OnUpdate()
    {
        if (BossShield1.Boss2 == true)
        {
            Bossmanager.TransitionState(BossStateType.BossCharge);
        }
        timer += timer;
        Bossmanager.FlipTO(parameter.target);
        Bossmanager.transform.position = Vector2.MoveTowards(Bossmanager.transform.position,
        parameter.target.position, parameter.throwSpeed * Time.deltaTime);
        if (timer>=parameter .throwtime)
        {
            Bossmanager.TransitionState(BossStateType.BossChase);
        }
    }

    public void OnExit()
    {
        attack = false;
    }
}