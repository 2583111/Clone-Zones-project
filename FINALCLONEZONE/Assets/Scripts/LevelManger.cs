using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManger : MonoBehaviour
{

    public void Level0()
    {
        StartCoroutine(LoadLevelAsync(0));
    }

    public void Level1()
    {
        StartCoroutine(LoadLevelAsync(1));
    }

    public void Level2()
    {
        StartCoroutine(LoadLevelAsync(2));
    }

    public void Level3()
    {
        StartCoroutine(LoadLevelAsync(3));
    }

    public void Level4()
    {
        StartCoroutine(LoadLevelAsync(4));
    }

    public void Level5()
    {
        StartCoroutine(LoadLevelAsync(5));
    }

    public void Level6()
    {
        StartCoroutine(LoadLevelAsync(6));
    }

    public void Level7()
    {
        StartCoroutine(LoadLevelAsync(7));
    }

    private IEnumerator LoadLevelAsync(int levelIndex)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(levelIndex);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
