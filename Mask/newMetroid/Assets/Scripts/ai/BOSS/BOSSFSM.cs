using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public enum BossStateType
{
    BossIdle,  BossChase, BossCharge, BossThrow
}
[Serializable]
public class BossParameter
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
    public GameObject player;

    //public float attackSpeed = 3;
    //public bool shoot = false;
  
    
    public Rigidbody2D rb;
}

public class BOSSFSM : MonoBehaviour

{
    public static bool right;
    public BossParameter parameter;
    private BossIState currentState;
    private Dictionary<BossStateType, BossIState> states = new Dictionary<BossStateType, BossIState>();


    void Start()//添加各状态到字典
    {
        states.Add(BossStateType.BossIdle, new BossIdleState(this ));
        states.Add(BossStateType.BossChase, new BossChaseState(this));
        states.Add(BossStateType.BossCharge, new BossChargeState(this));
        states.Add(BossStateType.BossThrow, new BossThrowState(this));
        TransitionState(BossStateType.BossIdle);

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
        currentState.OnUpdate();
        parameter.player = GameObject.FindGameObjectWithTag("Player");
        parameter.target = parameter.player.transform;

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
    
    public void TransitionState(BossStateType type)
    {
        if (currentState! != null)
            currentState.OnExit();

        currentState = states[type];

        currentState.OnEnter();
    }
}





// Start is called before the first frame update
