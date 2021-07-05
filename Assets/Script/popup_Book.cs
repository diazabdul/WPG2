using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup_Book : MonoBehaviour
{
    public Canvas[] canvas;
    public bool a = false;

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
        if (a == false)
        {
            a = true;
            canvas[2].enabled = true;
        }
        else if (a == true)
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
        if (a == false)
        {
            a = true;
            canvas[4].enabled = true;
        }
        else if (a == true)
        {
            a = false;
            canvas[4].enabled = false;
        }
    }
    public void popup5()
    {
        if (a == false)
        {
            a = true;
            canvas[5].enabled = true;
        }
        else if (a == true)
        {
            a = false;
            canvas[5].enabled = false;
        }
    }

}
