using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestAnswers : MonoBehaviour
{
    //private var created to connect keycode and button
    private Button CorrectChestAnswer;
    private Button WrongChestAnswer;

    //private reference to UI button
    void Awake()
    {
        CorrectChestAnswer = GetComponent<Button>();
        WrongChestAnswer = GetComponent<Button>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Return))
        {
            OutlineColorSelection(CorrectChestAnswer.colors.pressedColor);
            
        }
        else
        {
            OutlineColorSelection(CorrectChestAnswer.colors.normalColor);
        }

    }


    //Start Couroutine();

    //usability feature that outlines selection for user respectively
    void OutlineColorSelection(Color color)
    {
        Graphic graphic = GetComponent<Graphic>();
        graphic.CrossFadeColor(color, CorrectChestAnswer.colors.fadeDuration, true, true);
    }
}


