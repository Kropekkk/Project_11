using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private Animator animator;

    private CharacterBehaviour currentBehaviour;

    private void Start()
    {
        Init();
    }

    public void Init()
    {
        SetCharacterMovement(CharacterBehaviour.Move);
    }

    private void FixedUpdate()
    {
        if(currentBehaviour == CharacterBehaviour.Move)
        {
            rigidbody.velocity = new Vector3(2.5f, 0, 0);
        }
    }

    private void SetCharacterMovement(CharacterBehaviour behaviour)
    {
        currentBehaviour = behaviour;

        switch(behaviour)
        {
            case CharacterBehaviour.Idle:
                animator.SetBool("Attack_04", true);
                break;
            case CharacterBehaviour.Move:
                animator.SetBool("WalkFront", true);
                break;
            case CharacterBehaviour.Attack:
                animator.SetBool("Attack_04", true);
                break;
        }
    }

    private async void Attack(Enemy enemy)
    {
        animator.SetBool("WalkFront", false);
        SetCharacterMovement(CharacterBehaviour.Attack);

        await Task.Delay(750);

        enemy.Hit(75);

        if(enemy.IsAlive())
        {
            Attack(enemy);
            Debug.Log("Takl");
        }
        else
        {
            await Task.Delay(1000);

            SetCharacterMovement(CharacterBehaviour.Move);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Enemy>())
        {
            Attack(other.gameObject.GetComponent<Enemy>());

            Debug.Log("Halo123");

        }
    }
}