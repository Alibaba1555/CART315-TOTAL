using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{
    public int points = 0;
    public int lives = 3;

    public static GameManagement S;

    public int HighScore;





    //public SceneManager sceneManager;

    void Awake()
    {
        S = this;

        DontDestroyOnLoad(this);
    }

    void Start()
    {
    }

    public void LoseLife()
    {
        lives -= 1;
        Debug.Log(lives);

        if (lives <= 0)
        {
            if (points > HighScore)
            {
                HighScore = points;
            }
            GameOver();

        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void AddPoint(int pointValue)
    {
        points += pointValue;
    }

    public void getHighScore()
    {

    }

    void Update()
    {

    }


}
