using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public enum BossStateType3
{
    BossIdle, BossChase, BossCharge, BossThrow
}
[Serializable]
public class BossParameter3
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
    public GameObject player;
    public GameObject boss;
}

public class BOSS3FSM : MonoBehaviour

{
    public static bool right;
    public BossParameter3 parameter;
    private BossIstate3 currentState;
    private Dictionary<BossStateType3, BossIstate3> states = new Dictionary<BossStateType3, BossIstate3>();


    void Start()//添加各状态到字典
    {
        states.Add(BossStateType3.BossIdle, new Boss3IdleState(this));
        states.Add(BossStateType3.BossChase, new Boss3ChaseState(this));
        states.Add(BossStateType3.BossCharge, new Boss3ChargeState(this));
        states.Add(BossStateType3.BossThrow, new Boss3ThrowState(this));
        TransitionState(BossStateType3.BossIdle);

        parameter.animator = GetComponent<Animator>();


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            parameter.health--;
        }
    }

    void Update()
    {
        if (parameter.health <= 4)
        {
            ChangeWorld.change = 1;
            parameter.boss.layer = 18;

        }
        if (GameObject.FindGameObjectWithTag("bossenemy") == null)
        {
            parameter.boss.layer = 18;
        }
        currentState.OnUpdate();
        if (parameter.shoot == true)
        {
            Instantiate(parameter.bulletPrefabs, parameter.BossFirepoint.position, parameter.BossFirepoint.rotation);
        }
        parameter.player = GameObject.FindGameObjectWithTag("Player");
        parameter.target = parameter.player.transform;

    }
    public void FlipTO(Transform target)//使怪物朝向正常
    {
        if (target != null)
        {
            if (transform.position.x > target.position.x)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                right = false;

            }
            else if (transform.position.x < target.position.x)
            {
                transform.localScale = new Vector3(1, 1, 1);
                right = true;
            }
        }
    }
    //private void OnDrawGizmos()
    //{
    //    Gizmos.DrawWireSphere(parameter.attackPoint.position, parameter.attackArea);
    //}

    public void TransitionState(BossStateType3 type)
    {
        if (currentState! != null)
            currentState.OnExit();

        currentState = states[type];

        currentState.OnEnter();
    }
}
