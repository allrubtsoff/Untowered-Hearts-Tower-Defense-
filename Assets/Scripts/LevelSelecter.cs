using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelecter : MonoBehaviour
{
    public Button[] levelButtons;

    private void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);
        //
        //Debug.Log(levelReached);
        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReached) levelButtons[i].interactable = false;

        }
    }

    public void Select(string levelName)
    {
        SceneManager.LoadScene(levelName);
        //sceneFader.FadeTo(levelName);
    }
}
