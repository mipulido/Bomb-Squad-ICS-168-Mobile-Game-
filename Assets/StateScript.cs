using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateScript : MonoBehaviour {

    private bool state;
    public Sprite enabledSprite, disabledSprite;

	// Use this for initialization
	void Start () {
        state = false;
	}

	// Update is called once per frame
	void Update () {
        if (state)
            GetComponent<Image>().sprite = enabledSprite;
        else
            GetComponent<Image>().sprite = disabledSprite;
    }

    public bool CheckState { get { return state; } }
    public void ChangeState (bool newState) { state = newState; }
}
