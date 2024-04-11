using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    [SerializeField] private int HP = 100;
    private Animator animator;

    private NavMeshAgent navAgent;
    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();
        navAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    public void takeDamage(int damageAmount)
    {
        HP -= damageAmount;

        if(HP <=0)
        {
            int randomValue = Random.Range(0, 2);

            if(randomValue == 0)
            {
                animator.SetTrigger("DIE1");
            }
            else
            {
                animator.SetTrigger("DIE2");
            }
        }
        else
        {
            animator.SetTrigger("DAMAGE");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 2.5f);

        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, 18f);

        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, 21f);
    }
}
