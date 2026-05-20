using UnityEngine;
public class GameManager : MonoBehaviour
{
    public int scoreLeft = 0;
    public int scoreRight = 0;
    public void ScoreLeft()
    {
        scoreLeft++;
        Debug.Log("Left: " + scoreLeft + " | Right: " + scoreRight);
    }
    public void ScoreRight()
    {
        scoreRight++;
        Debug.Log("Left: " + scoreLeft + " | Right: " + scoreRight);
    }
}

