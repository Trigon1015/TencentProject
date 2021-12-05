using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public enum BossStateType2
{
    BossIdle, BossChase, BossCharge, BossThrow
}
[Serializable]
public class BossParameter2
{
    public int health;
    public float throwSpeed;
    public float chaseSpeed;
    public float throwtime;
    public float idleTime;
    public float chargeSpeed;
    public Animator animator;
    public Transform target;
    public LayerMask targetLayer;
    public Transform attackPoint;
    public float attackArea;
    public Transform enemy;
    public float enemyvalue;
    public float attackSpeed = 3;
    public bool shoot = false;
    public GameObject bulletPrefabs;
    public UnityEngine.Transform BossFirepoint;
    public Rigidbody2D rb;
}

public class BOSS2FSM : MonoBehaviour

{
    public static bool right;
    public BossParameter2 parameter;
    private BossIstate2 currentState;
    private Dictionary<BossStateType2, BossIstate2> states = new Dictionary<BossStateType2, BossIstate2>();


    void Start()//添加各状态到字典
    {
        states.Add(BossStateType2.BossIdle, new Boss2IdleState(this));
        //states.Add(BossStateType2.BossChase, new BossChaseState(this));
        //states.Add(BossStateType2.BossCharge, new BossChargeState(this));
        //states.Add(BossStateType2.BossThrow, new BossThrowState(this));
        TransitionState(BossStateType2.BossIdle);

        parameter.animator = GetComponent<Animator>();


    }



    void Update()
    {
        currentState.OnUpdate();
        if (parameter.shoot == true)
        {
            Instantiate(parameter.bulletPrefabs, parameter.BossFirepoint.position, parameter.BossFirepoint.rotation);
        }

    }
    public void FlipTO(Transform target)//使怪物朝向正常
    {
        if (target != null)
        {
            if (transform.position.x > target.position.x)
            {
                transform.localScale = new Vector3(-2, 2, 1);
                right = false;

            }
            else if (transform.position.x < target.position.x)
            {
                transform.localScale = new Vector3(2, 2, 1);
                right = true;
            }
        }
    }
    //private void OnDrawGizmos()
    //{
    //    Gizmos.DrawWireSphere(parameter.attackPoint.position, parameter.attackArea);
    //}

    public void TransitionState(BossStateType2 type)
    {
        if (currentState! != null)
            currentState.OnExit();

        currentState = states[type];

        currentState.OnEnter();
    }
}