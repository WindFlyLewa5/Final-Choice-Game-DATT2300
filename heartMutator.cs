using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class heartMutator : MonoBehaviour
{
    public Text heartText;
    public Text questionTextBox;
    public Text resultTextBox;
    public Text op1TextBox;
    public Text op2TextBox;
    public Text op3TextBox;
    public GameObject fishButton;
    public GameObject questionBox;
    public GameObject resultBox;
    // Start is called before the first frame update
    void Start()
    {
        sampleArray.setQuestionTextBox(questionTextBox);
        sampleArray.setResultTextBox(resultTextBox);
        sampleArray.setop1TextBox(op1TextBox);
        sampleArray.setop2TextBox(op2TextBox);
        sampleArray.setop3TextBox(op3TextBox);
        sampleArray.setQuestionBox(questionBox);
        sampleArray.setResultBox(resultBox);
        sampleArray.setFishButton(fishButton);
    }

    // Update is called once per frame
    void Update()
    {
        heartText.text = sampleArray.getLove()+"%";
    }
}
