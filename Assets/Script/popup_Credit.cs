using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup_Credit : MonoBehaviour
{
    public Canvas[] canvas;
    public bool a = false;
    public bool charac = true;
    public void popup()
    {
        if (a == false)
        {
            a = true;
            canvas[0].enabled = true;
        }else if (a == true)
        {
            a = false;
            canvas[0].enabled = false;
        }
    }
    public void popup1()
    {
        if (a == false)
        {
            a = true;
            canvas[1].enabled = true;
        }
        else if (a == true)
        {
            a = false;
            canvas[1].enabled = false;
        }
    }
    public void popup2()
    {
        if (a == true)
        {
            a = true;
            charac = true;
            canvas[2].enabled = true;
            canvas[1].enabled = false;
            canvas[4].enabled = false;
        }
        else if (a == false)
        {
            a = false;
            canvas[2].enabled = false;
        }
    }
    public void popup3()
    {
        if (a == false)
        {
            a = true;
            canvas[3].enabled = true;
        }
        else if (a == true)
        {
            a = false;
            canvas[3].enabled = false;
        }
    }
    public void popup4()
    {
        if (a == true)
        {
            a = true;
            canvas[4].enabled = true;
            canvas[1].enabled = false;
            canvas[2].enabled = false;
            charac = false;
        }
        else if (a == false)
        {
            a = false;
            canvas[4].enabled = false;
        }
    }
    public void nonPopup()
    {
        if (a == false)
        {
            a = true;
            canvas[1].enabled = false;
        }
        else if (a == true)
        {
            a = false;
            canvas[1].enabled = true;
        }
    }
}
