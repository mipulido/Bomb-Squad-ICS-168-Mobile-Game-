using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonScript : MonoBehaviour {

    public Sprite pressedButton;

    void TaskOnClick()
    {
        GetComponent<SpriteRenderer>().sprite = pressedButton;
    }
}
