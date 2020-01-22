using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public string mainMenuLevel;
    public string goodEnd;
    public string mediumEnd;
    public string badEnd;
    public GameObject pause;
    private question question;

    public void PauseGame()
    {
        Time.timeScale = 0f;
        pause.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pause.SetActive(false);
    }
    public void scenearioOn()
    {
        if (sampleArray.getworms() == 0)
        {
            if(sampleArray.getLove() >= 80)
            {
                Application.LoadLevel(goodEnd);
            }
            else if(sampleArray.getLove() >= 40)
            {
                Application.LoadLevel(mediumEnd);
            }
            else
            {
                Application.LoadLevel(badEnd);
            }
        }
        else
        {
            sampleArray.wormloss();
            question = sampleArray.scenario();
            sampleArray.getQuestionTextBox().text = question.getScenario();
            sampleArray.getop1TextBox().text = question.getOption1();
            sampleArray.getop2TextBox().text = question.getOption2();
            sampleArray.getop3TextBox().text = question.getOption3();
            sampleArray.turnFBoff();
            sampleArray.turnQBon();
        }
    }
    public void backToGame()
    {
        sampleArray.turnRBoff();
        sampleArray.turnFBon();
    }
    public void scenarioOff()
    {
        sampleArray.getResultTextBox().text = question.getResult3();
        sampleArray.turnQBoff();
        sampleArray.turnRBon();
    }
    public void scenarioOffPos()
    {
        sampleArray.getResultTextBox().text = question.getResult1();
        sampleArray.heartGain();
        sampleArray.turnQBoff();
        sampleArray.turnRBon();
    }
    public void scenarioOffNeg()
    {
        sampleArray.getResultTextBox().text = question.getResult2();
        sampleArray.heartLoss();
        sampleArray.turnQBoff();
        sampleArray.turnRBon();
    }
    public void QuitToMain()
    {
        Time.timeScale = 1f;
        Application.LoadLevel(mainMenuLevel);
    }
}
