using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public enum FlyStateType
{
    Idle, Chase, Attack, Hit
}
[Serializable]

public class FlyParameter
{
    public int health;
    public float chaseSpeed;
    public Transform[] chasePoints;
    public Animator animator;
    public Transform target;
    public LayerMask targetLayer;
    public Transform attackPoint;
    public float attackArea;
    public Transform enemy;
    public float enemyvalue;
}

public class FlyFSM : MonoBehaviour

{
    public FlyParameter parameter;
    private FlyIState currentState;
    private Dictionary<FlyStateType, FlyIState> states = new Dictionary<FlyStateType, FlyIState>();




    // Start is called before the first frame update
    void Start()//添加各状态到字典
    {
        states.Add(FlyStateType.Idle, new FlyIdleState(this));
        
        states.Add(FlyStateType.Chase, new FlyChaseState(this));
        
        states.Add(FlyStateType.Attack, new FlyAttackState(this));

        TransitionState(FlyStateType.Idle);

        parameter.animator = GetComponent<Animator>();
        parameter.target = null;
    }

    // Update is called once per frame
    void Update()
    {
        currentState.OnUpdate();
    }

    public void TransitionState(FlyStateType type)
    {
        if (currentState! != null)
            currentState.OnExit();

        currentState = states[type];

        currentState.OnEnter();
    }

    public void FlipTO(Transform target)//使怪物朝向正常
    {
        if (target != null)
        {
            if (transform.position.x > target.position.x)
            {
                transform.localScale = new Vector3(5,5 ,5);

            }
            else if (transform.position.x < target.position.x)
            {
                transform.localScale = new Vector3(-5, 5, 5);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)//检测玩家是否进入怪物视野
    {
        if (other.CompareTag("Player"))
        {
            parameter.target = other.transform;

        }
    }

    

    // private void OnDrawGizmos()
    // {
    //     Gizmos.DrawWireSphere(parameter.attackPoint.position, parameter.attackArea); 
    // }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(parameter.enemy.position, parameter.enemyvalue);
    }
}
