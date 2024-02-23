using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script15_KeyButtonInput : MonoBehaviour
{
    public Image graphic;
    public Sprite standard;
    public Sprite downgfx;
    public Sprite upgfx;
    public Sprite heldgfx;
    public Text boolDisplay1;
    public Text boolDisplay2;
    public Text boolDisplay3;
    void Start()
    {
        graphic.sprite = standard;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        //KEY INPUT
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);

        if(down)
        {
            graphic.sprite = downgfx;
        }
        else if(held)
        {
            graphic.sprite = heldgfx;
        }
        else if(up)
        {
            graphic.sprite = upgfx;
        }
        else
        {
            graphic.sprite = standard;
        }

        boolDisplay1.text = " " + down;
        boolDisplay1.text = " " + held;
        boolDisplay3.text = " " + held;
        */
        
        //Button Input
        bool down = Input.GetButtonDown("Jump");
        bool held = Input.GetButton("Jump");
        bool up = Input.GetButtonUp("Jump");

        if(down)
        {
            graphic.sprite = downgfx;
        }
        else if(held)
        {
            graphic.sprite = heldgfx;
        }
        else if(up)
        {
            graphic.sprite = upgfx;
        }
        else
        {
            graphic.sprite = standard;
        }
        boolDisplay1.text = " " + down;
        boolDisplay1.text = " " + held;
        boolDisplay3.text = " " + held;
    }
}
