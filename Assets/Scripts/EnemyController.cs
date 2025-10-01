using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator animator;
    private ParticleSystem system;
    void Start()
    {
        animator = GetComponent<Animator>();
        system = GetComponent<ParticleSystem>();
    }

    public void GotHit()
    {
        animator.ResetTrigger("GotHit");
        animator.SetTrigger("GotHit");

    }
}
