using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour {

    public Texture braidTexture;

    private float x = 0;
    private float y = 0;

    // OnGUI is called once per frame
    void OnGUI() {
        GUI.DrawTexture(new Rect(x, y, 100, 100), braidTexture);
        x = x + 1;
    }
}
