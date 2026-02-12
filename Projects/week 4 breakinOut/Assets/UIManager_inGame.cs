using UnityEngine;
using TMPro;
public class UIManager_inGame : MonoBehaviour
{

    public TextMeshProUGUI lifeText;
    public TextMeshProUGUI pointsText;

    void Update()
    {
        lifeText.text = "Lives: " + GameManagement.S.lives;
        pointsText.text = "Score: " + GameManagement.S.points;
    }
}
