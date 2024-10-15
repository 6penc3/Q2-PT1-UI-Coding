using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static UnityEditor.Experimental.GraphView.GraphView;
using Unity.VisualScripting;

public class Stuff : MonoBehaviour
{
    public string labelText = "Hello!";
    public Texture2D Image;
    public Vector2 position;
    public Vector2 size;
    private void OnGUI()
    {
        GUI.Box(new Rect(85, 105, 1298, 543), "Start");

        if (GUI.Button(new Rect(111, 132, 498, 117), "Option 1"))
        {
            labelText = "Name: Isaac\n\rAge: 26\n\rPhysical Damage: 20\n\rArmor: 15\n\rIntelligence: 42\n\rSpeed: 8";
        }

        if (GUI.Button(new Rect(111, 313, 498, 117), "Option 2"))
        {
            labelText = "Name: Suijouki\n\rAge: 21\n\rPhysical Damage: 30\n\rArmor: 12\n\rIntelligence: 35\n\rSpeed: 10";
        }

        if (GUI.Button(new Rect(111, 495, 498, 117), "Option 3"))
        {
            
            labelText = "Name: Kuroaji\n\rAge: 24\n\rPhysical Damage: 18\n\rArmor: 12\n\rIntelligence: 45\n\rSpeed: 12";
        }

        GUI.Label(new Rect(800, 300, 500, 500), labelText);
    }
}

