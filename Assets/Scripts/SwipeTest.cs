using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTest : MonoBehaviour {
    public Swipe swipeControls;

	// Update is called once per frame
	private void Update () {
        if (swipeControls.Tap)
            Debug.Log("Tap Detected");

        if (swipeControls.SwipeLeft)
            Debug.Log("Left Swipe Detected");
        if (swipeControls.SwipeRight)
            Debug.Log("Right Swipe Detected");
        if (swipeControls.SwipeUp)
            Debug.Log("Up Swipe Detected");
        if (swipeControls.SwipeDown)
            Debug.Log("Down Swipe Detected");
    }
}
