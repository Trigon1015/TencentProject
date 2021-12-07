using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2Enemy : MonoBehaviour
{
    public int health;
    public float moveSpeed;
    public Animator animator;
    
    public LayerMask targetLayer;
    public Transform attackPoint;
    public float attackArea;
    public Transform enemy;
    public GameObject  BossEnemy;
    public float enemyvalue;
    public Transform target;
    public GameObject player;
    public GameObject bossdead;
    // Start is called before the first frame update
    void Start()
    {
      
    }
    //private void OnDrawGizmos()
    //  {
    //     Gizmos.DrawWireSphere(attackPoint.position, attackArea);
    //  }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            health--;
            Debug.Log(health);
        }
    }
    // Update is called once per frame
    void Update()
    {

        if (health <= 0)
        {
            Instantiate(bossdead, transform.position, transform.rotation);

            gameObject.SetActive(false);
        }
        player =GameObject.FindGameObjectWithTag("Player");
        target = player.transform;
        if (target != null)
        {
            if (transform.position.x > target.position.x)
            {
                transform.localScale = new Vector3(1, 1, 1);
                

            }
            else if (transform.position.x < target.position.x)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                
            }
        }
        BossEnemy.transform .position = Vector2.MoveTowards(BossEnemy.transform.position,
        target.position, moveSpeed * Time.deltaTime);
        if (Physics2D.OverlapCircle(enemy.position, enemyvalue, targetLayer))
        {

            PlayerManager.PlayerHP--;
           
        }
        if (Physics2D.OverlapCircle(attackPoint .position, attackArea , targetLayer))
        {
            int modelindex = Random.Range(0, 8);
            
            if (modelindex==0)
            {
                animator.Play("1");
            }
            if (modelindex == 1)
            {
                animator.Play("2");
            }
            if (modelindex == 2)
            {
                animator.Play("3");
            }
            if (modelindex == 3)
            {
                animator.Play("4");
            }
            if (modelindex == 4)
            {
                animator.Play("5");
            }
            if (modelindex == 5)
            {
                animator.Play("6");
            }
            if (modelindex == 6)
            {
                animator.Play("7");
            }
            if (modelindex == 7)
            {
                animator.Play("8");
            }
           


        }
    }
}
