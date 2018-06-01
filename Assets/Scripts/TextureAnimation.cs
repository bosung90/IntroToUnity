using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureAnimation : MonoBehaviour {

    public Texture[] braidTextures;

    // 1.
    private int index = 0;

    // 2.
    //private float totalTime = 0;

    // 3.
    //private float x = 0;
    //private float y = 0;

    // 4.
    //private bool isRight = true;

    // 5.
    public Texture EnemyTexture;
    //private float enemyX = 200, enemyY = 200;
    //private bool isColliding = false;

    // 6.
    //private float speedX = 0, speedY = 0, accelX = 0, accelY = 200f;

    // OnGUI is called once per frame
    void OnGUI() {

        // 1. Let's do animation
        //GUI.DrawTexture(new Rect(0, 0, 196, 196), braidTextures[index]);
        //index = (index + 1) % braidTextures.Length;

        // 2. Let's do animation slower
        //GUI.DrawTexture(new Rect(0, 0, 196, 196), braidTextures[index]);
        //totalTime += Time.deltaTime;
        //index = (int)((totalTime*12) % braidTextures.Length);

        // 3. Let's animate only when moving
        //GUI.DrawTexture(new Rect(x, y, 196, 196), braidTextures[index]);
        //if(Input.GetKey(KeyCode.RightArrow)) {
        //    x = x + 1;
        //}
        //if(Input.GetKey(KeyCode.LeftArrow)) {
        //    x = x - 1;
        //}
        //if(Input.GetKey(KeyCode.UpArrow)) {
        //    y = y - 1;
        //}
        //if(Input.GetKey(KeyCode.DownArrow)) {
        //    y = y + 1;
        //}
        //if(Input.GetKey(KeyCode.RightArrow) ||
        //    Input.GetKey(KeyCode.LeftArrow) ||
        //    Input.GetKey(KeyCode.UpArrow) ||
        //    Input.GetKey(KeyCode.DownArrow)) {
        //    totalTime += Time.deltaTime;
        //    index = (int)((totalTime * 12) % braidTextures.Length);
        //}

        // 4. Let's flip the Texture when moving left
        //if(isRight) {
        //    GUI.DrawTexture(new Rect(x, y, 196, 196), braidTextures[index]);
        //} else {
        //    GUI.DrawTexture(new Rect(x + 196, y, -196, 196), braidTextures[index]);
        //}

        //if(Input.GetKey(KeyCode.RightArrow)) {
        //    x = x + 1;
        //    isRight = true;
        //}
        //if(Input.GetKey(KeyCode.LeftArrow)) {
        //    x = x - 1;
        //    isRight = false;
        //}
        //if(Input.GetKey(KeyCode.UpArrow)) {
        //    y = y - 1;
        //}
        //if(Input.GetKey(KeyCode.DownArrow)) {
        //    y = y + 1;
        //}
        //if(Input.GetKey(KeyCode.RightArrow) ||
        //    Input.GetKey(KeyCode.LeftArrow) ||
        //    Input.GetKey(KeyCode.UpArrow) ||
        //    Input.GetKey(KeyCode.DownArrow)) {
        //    totalTime += Time.deltaTime;
        //    index = (int)((totalTime * 12) % braidTextures.Length);
        //}

        // 5. Let's do collision detection
        //GUI.DrawTexture(new Rect(enemyX, enemyY, EnemyTexture.width, EnemyTexture.height), EnemyTexture);
        //// 5a. Check if within x boundary
        //if(enemyX >= x && enemyX <= x + 100
        //    // 5b. Check if within y boundary
        //    && enemyY >= y && enemyY <= y + 100
        //    ) {
        //    isColliding = true;
        //} else {
        //    isColliding = false;
        //}
        //if(isRight) {
        //    if(isColliding) {
        //        GUI.DrawTexture(new Rect(x, y, 196, 196), braidTextures[index], ScaleMode.ScaleToFit, true, 1, Color.red, 0, 0);
        //    } else {
        //        GUI.DrawTexture(new Rect(x, y, 196, 196), braidTextures[index]);
        //    }
        //} else {
        //    if(isColliding) {
        //        // There is a bug when we flip horizontally and also change color, it also flips vertically.
        //        GUI.DrawTexture(new Rect(x + 196, y, -196, 196), braidTextures[index], ScaleMode.ScaleToFit, true, 0, Color.white, 0, 0);
        //    } else {
        //        GUI.DrawTexture(new Rect(x + 196, y, -196, 196), braidTextures[index]);
        //    }
        //}


        // 6. Let's add some physics
        //x += speedX * Time.deltaTime;
        //y += speedY * Time.deltaTime;

        //speedX += accelX * Time.deltaTime;
        //speedY += accelY * Time.deltaTime;

        //// 6a. Platform
        //if(y >= 600) {
        //    y = 600;
        //    speedY = 0;
        //}

        //// 6b. Jump
        //if(Input.GetKeyDown(KeyCode.Space)) {
        //    speedY = -200f;
        //}

        // Bonus
        // 7. Spawn some bullets when you press a button
    }
}
