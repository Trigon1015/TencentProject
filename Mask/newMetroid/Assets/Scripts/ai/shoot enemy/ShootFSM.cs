using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum ShootStateType
{
    Idle,Attack
}
[Serializable]
public class ShootParameter
{
    public int health;
    public float time;
    public Animator animator;
    public Transform target;
    public LayerMask targetLayer;
    public Transform attackPoint;
    public Transform enemy;
    public float enemyvalue;
    public GameObject bulletPrefabs;
    public float attackSpeed = 3;
    public  bool shoot = false;
}

public class ShootFSM : MonoBehaviour

{
    public ShootParameter parameter;
    private ShootIState currentState;
    private Dictionary<StateType, ShootIState> states = new Dictionary<StateType, ShootIState>();




    // Start is called before the first frame update
    void Start()//添加各状态到字典
    {
        states.Add(StateType.Idle, new ShootIdleState(this));
        states.Add(StateType.Attack, new ShootAttackState(this));

        TransitionState(StateType.Idle);

        parameter.animator = GetComponent<Animator>();
        parameter.target = null;
    }

    // Update is called once per frame
    void Update()
    {
        currentState.OnUpdate();
        if (parameter.shoot==true)
        { Instantiate(parameter.bulletPrefabs, parameter.attackPoint.position, parameter.attackPoint.rotation); }
    }

    public void TransitionState(StateType type)
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
                transform.localScale = new Vector3(5, 5, 5);

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

    private void OnTriggerExit2D(Collider2D other)//检测玩家是否离开怪物视野
    {
        if (other.CompareTag("Player"))
        {
            parameter.target = null;

        }
    }

    // private void OnDrawGizmos()
    // {
    //     Gizmos.DrawWireSphere(parameter.attackPoint.position, parameter.attackArea); 
    // }
    //private void OnDrawGizmos()
    //{
    //    Gizmos.DrawWireSphere(parameter.enemy.position, parameter.enemyvalue);
    //}
}

