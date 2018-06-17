using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeLogic : MonoBehaviour {

    public Swipe swipe;
    public Text panelText;

    int currentPanel;

	// Use this for initialization
	void Start () {
        currentPanel = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if (swipe.SwipeRight && currentPanel > 1)
        {
            currentPanel -= 1;
            //panelText.text = currentPanel.ToString();
        }
        else if (swipe.SwipeLeft && currentPanel < 5)
        {
            currentPanel += 1;
            //panelText.text = currentPanel.ToString();
        }
	}
}
