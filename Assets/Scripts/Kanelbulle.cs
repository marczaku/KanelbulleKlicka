using System;
using UnityEngine;
using UnityEngine.Events;

public class Kanelbulle : MonoBehaviour
{
    public UnityEvent<int> KanelbullarChanged;
    public UnityEvent<string> KanelbullarTextChanged;
    public UnityEvent<string> PlayerNameChanged;
    public UnityEvent<bool> GenerateKanelbullarChanged;
    private int kanelbullar;
    private string playerName;
    private bool generateKanelbullar;

    public GameController GameController;
    public OldGameController OldGameController;

    void Start()
    {
        this.kanelbullar = PlayerPrefs.GetInt("amount", 10);
        this.playerName = PlayerPrefs.GetString("playerName", "Unnamed");
        int generateInt = PlayerPrefs.GetInt("generate", 0);
        this.generateKanelbullar = generateInt != 0;

        KanelbullarChanged.Invoke(this.kanelbullar); // 0
        KanelbullarTextChanged.Invoke(this.kanelbullar.ToString());
        PlayerNameChanged.Invoke(this.playerName);
        GenerateKanelbullarChanged.Invoke(this.generateKanelbullar);
    }
    
    public void IncreaseKanelbullar()
    {
        kanelbullar++;
        KanelbullarChanged.Invoke(this.kanelbullar); // 1
        KanelbullarTextChanged.Invoke(this.kanelbullar.ToString());

        PlayerPrefs.SetInt("amount", kanelbullar);
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