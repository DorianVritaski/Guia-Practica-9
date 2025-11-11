using UnityEngine;

public class AIController : MonoBehaviour, IInteractable
{

    [Header("AI Settings")]

    public Transform[] waypoints;

    public float patrolSpeed = 2f;

    public float chaseSpeed = 5f;

    public float detectionRadius = 10f;

    public float loseSightRadius = 15f;

    public float stunDuration = 3f;


    private AIState _currenteState;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        ChangeState(new PatrolState(this));
    }

    // Update is called once per frame
    private void Update()
    {
        _currenteState?.UpdateState();
    }

    public void ChangeState(AIState newState)
    {
        _currenteState?.OnExit();
        _currenteState = newState;
        _currenteState.OnEnter();
    }

    public void Stun()
    {
        // Solo podemos aturdir si no estamos ya aturdidos
        if (_currenteState is StunState) return;

        ChangeState(new StunState(this));
    }

    public void Interact()
    {
        Stun();
    }
}
