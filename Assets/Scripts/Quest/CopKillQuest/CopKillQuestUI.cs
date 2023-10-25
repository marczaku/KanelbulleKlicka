using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CopKillQuestUI : MonoBehaviour
{
    public TMP_Text label;
    public CopKillQuest quest;

    void Start()
    {
        UpdateUI();
    }
    
    public void UpdateUI()
    {
        Debug.Log("Update UI.");
        if (quest.IsAccepted())
        {
            this.label.text = $"{quest.GetCopsKilled()}/2 Cops Killed.";
        }
        if(!quest.IsAccepted())
        {
            this.label.text = "";
        }
    }
}
