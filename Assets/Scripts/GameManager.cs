using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int playerAScore = 0;
    [SerializeField] private int playerBScore = 0;

    [SerializeField] private BallController ballController;

    public void IncrementPlayerAScore()
    {
        playerAScore++;
        ballController.ResetPosition();
    }

    public void IncrementPlayerBScore()
    {
        playerBScore++;
        ballController.ResetPosition();
    }
}
