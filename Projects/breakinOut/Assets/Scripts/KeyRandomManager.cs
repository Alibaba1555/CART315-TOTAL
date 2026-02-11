using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class KeyRandomManager : MonoBehaviour
{
    public PaddleScript PlayerA;
    public PaddleScript playerB;

    public float shuffleInterval = 5f;
    public UIController ui;

    private List<KeyCode> availableKeys = new List<KeyCode>();

    void Awake()
    {
        GenerateKeys();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(ShuffleKeysRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    void GenerateKeys()
    {
        availableKeys.Clear();

        for (KeyCode k = KeyCode.A; k < KeyCode.Z; k++)
        {
            availableKeys.Add(k);
        }
    }

    IEnumerator ShuffleKeysRoutine()
    {
        while (true)
        {
            for (int i = Mathf.RoundToInt(shuffleInterval); i > 0; i--)
            {
                ui.UpdateCountdown(i);
                yield return new WaitForSeconds(1f);
            }
            ShuffleAndAssignKeys();
        }
    }

    void ShuffleAndAssignKeys()
    {
        for (int i = 0; i < availableKeys.Count; i++)
        {
            int rand = Random.Range(i, availableKeys.Count);
            KeyCode tmp = availableKeys[i];
            availableKeys[i] = availableKeys[rand];
            availableKeys[rand] = tmp;
        }

        PlayerA.SetKeys(availableKeys[0], availableKeys[1]);
        playerB.SetKeys(availableKeys[2], availableKeys[3]);

        ui.updateKeys(availableKeys[0], availableKeys[1], availableKeys[2], availableKeys[3]);
    }
}
