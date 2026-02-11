using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public TMP_Text leftUpKeyText;
    public TMP_Text leftDownKeyText;
    public TMP_Text RightUpKeyText;
    public TMP_Text RightDownKeyText;

    public TMP_Text countdownText;

    public void updateKeys(KeyCode aUp, KeyCode aDown, KeyCode bUp, KeyCode bDown)
    {
        leftUpKeyText.text = aUp.ToString();
        leftDownKeyText.text = aDown.ToString();
        RightUpKeyText.text = bUp.ToString();
        RightDownKeyText.text = bDown.ToString();
    }

    public void UpdateCountdown(int value)
    {
        countdownText.text = value.ToString();
    }
}
