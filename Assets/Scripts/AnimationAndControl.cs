using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAndControl : MonoBehaviour {

    public Texture braidTexture;

    private float x = 0;
    private float y = 0; 

    // OnGUI is called once per frame
    void OnGUI () {
        GUI.DrawTexture(new Rect(x, y, 100, 100), braidTexture);
        if(Input.GetKey(KeyCode.RightArrow)) {
            Debug.Log("Right Arrow is Pressed!");
            x = x + 1;
        }
        if(Input.GetKey(KeyCode.LeftArrow)) {
            x = x - 1;
        }
        if(Input.GetKey(KeyCode.UpArrow)) {
            y = y - 1;
        }
        if(Input.GetKey(KeyCode.DownArrow)) {
            y = y + 1;
        }
    }
}
