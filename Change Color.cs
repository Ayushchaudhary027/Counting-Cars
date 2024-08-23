using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color[] colors;
    public Renderer[] comp;

    public void Red()
    {
        for (int i = 0; i < comp.Length; i++)
            comp[i].material.color = colors[0];
    }
    public void Green()
    {
        for (int i = 0; i < comp.Length; i++)
            comp[i].material.color = colors[1];
    }
    public void Black()
    {
        for (int i = 0; i < comp.Length; i++)
            comp[i].material.color = colors[2];
    }
    public void Yellow()
    {
        for (int i = 0; i < comp.Length; i++)
            comp[i].material.color = colors[3];
    }
    public void Blue()
    {
        for (int i = 0; i < comp.Length; i++)
            comp[i].material.color = colors[4];
    }
}
