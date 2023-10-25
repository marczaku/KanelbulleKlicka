using UnityEngine;
using UnityEngine.Events;

public class CopKillQuest : MonoBehaviour
{
    public UnityEvent QuestStartedEvent;
    public UnityEvent CopsKilledChangeEvent;
    
    private bool isAccepted;
    [SerializeField]
    private int copsKilled;

    public bool IsAccepted()
    {
        return this.isAccepted;
    }

    public int GetCopsKilled()
    {
        return this.copsKilled;
    }

    public void StartQuest()
    {
        if (this.isAccepted) return;
        
        this.isAccepted = true;
        this.QuestStartedEvent.Invoke();
    }

    public void OnCopKilled()
    {
        if (!this.isAccepted) return;
        if (this.copsKilled >= 2) return;
        
        this.copsKilled++;
        this.CopsKilledChangeEvent.Invoke();
    }
}
