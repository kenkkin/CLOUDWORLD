using System.Collections;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] SpriteRenderer characterRenderer, weaponRenderer;

    [SerializeField] Animator animator;

    [SerializeField] float delay = 0.3f;

    private bool attackBlocked;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Attack()
    {
        if (attackBlocked)
            return;
        animator.SetTrigger("Attack");
        attackBlocked = true;
        StartCoroutine(DelayAttack());
    }

    private IEnumerator DelayAttack()
    {
        yield return new WaitForSeconds(delay);
        attackBlocked = false;
    }
}
