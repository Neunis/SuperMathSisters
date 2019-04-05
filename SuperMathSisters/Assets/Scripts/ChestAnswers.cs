using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestAnswers : MonoBehaviour
{
    //what allows you to press button
    public KeyCode Key;
    //private var created to connect keycode and button
    private Button ChestAnswer;

    //private reference to UI button
    void Awake()
    {
        ChestAnswer = GetComponent<Button>();
    }

    bool chosen;

    void Update()
    {
        if (Input.GetKeyDown(Key))
        {
            OutlineColorSelection(ChestAnswer.colors.pressedColor);
            ChestAnswer.onClick.Invoke();
        }
        else if (Input.GetKeyUp(Key))
        {
            OutlineColorSelection(ChestAnswer.colors.normalColor);
        }
    }


    //usability feature that outlines selection for user respectively
    void OutlineColorSelection(Color color)
    {
        Graphic graphic = GetComponent<Graphic>();
        graphic.CrossFadeColor(color, ChestAnswer.colors.fadeDuration, true, true);
    }
}


