using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public string playGameLevel;

    public void PlayGame()
    {
        sampleArray.setWorms(10);
        sampleArray.setLove(50);
        int[] foo = new int[10];
        for(int i = 0; i < foo.Length; i++)
        {
            foo[i] = i+1;
        }
        sampleArray.setArray(foo);
        Application.LoadLevel(playGameLevel);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
