using System.Collections;
using UnityEngine;

public class StunState : AIState
{
    public StunState(AIController controller) : base(controller) { }

    public override void OnEnter()
    {
        Debug.Log("Entrando en estado de Aturdimiento.");
        m_agent.isStopped = true; // Detenemos al agente
        m_controller.StartCoroutine(StunSequence());
    }

    public override void UpdateState()
    {
        // La IA no hace nada mientras está aturdida.
    }

    public override void OnExit()
    {
        m_agent.isStopped = false; // Reanudamos el movimiento del agente al salir.
    }

    private IEnumerator StunSequence()
    {
        yield return new WaitForSeconds(m_controller.stunDuration);
        Debug.Log("Aturdimiento terminado. Volviendo a patrullar.");
        m_controller.ChangeState(new PatrolState(m_controller));
    }
}
