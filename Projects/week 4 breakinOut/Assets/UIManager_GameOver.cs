using UnityEngine;
using TMPro;


public class UIManager_GameOver : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI finalScoreText;

    void Start()
    {
        finalScoreText.text = "Final Score: " + GameManagement.S.points;
        highScoreText.text = "High Score: " + GameManagement.S.HighScore;
    }

}
