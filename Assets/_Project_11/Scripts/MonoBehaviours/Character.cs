using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private Animator animator;
    [SerializeField] private CharacterData characterData;

    private CharacterBehaviour currentBehaviour;

    private int health;

    private void Start()
    {
        Init();
    }

    public void Init()
    {
        health = characterData.Health;
        SetCharacterMovement(CharacterBehaviour.Move);
    }

    private void FixedUpdate()
    {
        if(currentBehaviour == CharacterBehaviour.Move)
        {
            rigidbody.velocity = new Vector3(characterData.Speed, 0, 0);
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

        enemy.Hit(characterData.Damage);

        if(enemy.IsAlive())
        {
            Attack(enemy);
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
        }
    }
}