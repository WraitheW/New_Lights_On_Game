using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightsOnButton : MonoBehaviour
{
    public bool isActive;
    public Sprite activeMaterial;
    public Sprite inactiveMaterial;

    public LightsOnButton[] adjacentButtons;

    //MAKE ME AN EVENT
    void Start()
    {
        //activeMaterial = Resources.Load<Sprite>("Materials/Active");
        //inactiveMaterial = Resources.Load<Sprite>("Materials/Passive");

        if (isActive)
        {
            GetComponent<Image>().sprite = inactiveMaterial;
            isActive = false;
        }
        else
        {
            GetComponent<Image>().sprite = activeMaterial;
            isActive = true;
        }
    }

    public void ChangeColor()
    {
        if (isActive)
        {
            GetComponent<Image>().sprite = inactiveMaterial;
            isActive = false;
        }
        else
        {
            GetComponent<Image>().sprite = activeMaterial;
            isActive = true;
        }
    }

    public void ChangeAdjacent()
    {
        foreach (LightsOnButton b in adjacentButtons)
        {
            if (b.isActive)
            {
                b.GetComponent<Image>().sprite = b.inactiveMaterial;
                b.isActive = false;
            }
            else if (!b.isActive)
            {
                b.GetComponent<Image>().sprite = b.activeMaterial;
                b.isActive = true;
            }
        }
    }

    public void Reset()
    {
        isActive = false;
        GetComponent<Image>().sprite = inactiveMaterial;
    }

    public void Enable()
    {
        isActive = true;
        GetComponent<Image>().sprite = activeMaterial;
    }
}
