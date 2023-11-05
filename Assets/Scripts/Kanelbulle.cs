using System;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.Events;

public class Kanelbulle : MonoBehaviour
{
    public UnityEvent<string> PlayerNameChanged;
    public UnityEvent<bool> GenerateKanelbullarChanged;
    public IntVariable Count;
    private string playerName;
    private bool generateKanelbullar;

    public GameController GameController;
    public OldGameController OldGameController;

    void Start()
    {
        this.Count.SetValue(PlayerPrefs.GetInt("amount", 10));
        this.playerName = PlayerPrefs.GetString("playerName", "Unnamed");
        int generateInt = PlayerPrefs.GetInt("generate", 0);
        this.generateKanelbullar = generateInt != 0;

        PlayerNameChanged.Invoke(this.playerName);
        GenerateKanelbullarChanged.Invoke(this.generateKanelbullar);
    }
    
    public void IncreaseKanelbullar()
    {
        Count.SetValue(Count.GetValue()+1);
        Count.ValueChanged.Invoke(50);
        PlayerPrefs.SetInt("amount", Count.GetValue());
    }

    public void SetPlayerName(string name)
    {
        this.playerName = name;
        PlayerPrefs.SetString("playerName", name);
    }

    public void ActivateGenerateKanelbullar(bool value)
    {
        this.generateKanelbullar = value;
        // save value
        PlayerPrefs.SetInt("generate", value ? 1 : 0); // "True", "False"
    }

    private void FixedUpdate()
    {
        if (this.generateKanelbullar)
        {
            IncreaseKanelbullar();
        }
    }
}