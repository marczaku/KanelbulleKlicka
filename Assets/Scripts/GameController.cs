using UnityEngine;

[CreateAssetMenu(fileName = "GameController", menuName = "Kanelbullar/GameController", order = 0)]
public class GameController : ScriptableObject
{
    public Transform transform;
    public int timeLeft;

    public void RestartGame()
    {
        
    }

    public void DoUpdate()
    {
    }
}
