using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static UnityEditor.Experimental.GraphView.GraphView;
using Unity.VisualScripting;

public class Stuff : MonoBehaviour
{
    public string playerStats = "Player Stats";

    public int playerOneAttack = 20;
    public int playerOneDefense = 15;
    public int playerOneSpeed = 8;
    public int playerOneLuck = 10;
    public int playerOneIntelligence = 42;
    public int playerOneSpecial = 20;

    public int playerTwoAttack = 30;
    public int playerTwoDefense = 12;
    public int playerTwoSpeed = 10;
    public int playerTwoLuck = 4;
    public int playerTwoIntelligence = 35;
    public int playerTwoSpecial = 15;

    public int playerThreeAttack = 18;
    public int playerThreeDefense = 12;
    public int playerThreeSpeed = 12;
    public int playerThreeLuck = 9;
    public int playerThreeIntelligence = 45;
    public int playerThreeSpecial = 20;

    public string labelText = "Hello!";
    public Texture2D Image;
    public Vector2 position;
    public Vector2 size;
    private void OnGUI()
    {
        GUI.Box(new Rect(85, 105, 1298, 543), "Start");

        if (GUI.Button(new Rect(111, 132, 498, 117), "Option 1"))
        {


            labelText = "Player One\n\rName: Isaac\n\rAttack: " + playerOneAttack + "\n\rDefense: " + playerOneDefense + "\n\rSpeed: " + playerOneSpeed + "\n\rLuck: " + playerOneLuck + "\n\rIntelligence: " + playerOneIntelligence + "\n\rSpecial: " + playerOneSpecial;
        }

        if (GUI.Button(new Rect(111, 313, 498, 117), "Option 2"))
        {
            labelText = "Player Two\n\rName: Suijouki\n\rAttack: " + playerTwoAttack + "\n\rDefense: " + playerTwoDefense + "\n\rSpeed: " + playerTwoSpeed + "\n\rLuck: " + playerTwoLuck + "\n\rIntelligence: " + playerTwoIntelligence + "\n\rSpecial: " + playerTwoSpecial;
        }

        if (GUI.Button(new Rect(111, 495, 498, 117), "Option 3"))
        {

            labelText = "Player Three\n\rName: Kuroaji\n\rAttack: " + playerThreeAttack + "\n\rDefense: " + playerThreeDefense + "\n\rSpeed: " + playerThreeSpeed + "\n\rLuck: " + playerThreeLuck + "\n\rIntelligence: " + playerThreeIntelligence + "\n\rSpecial: " + playerThreeSpecial;
        }

        GUI.Label(new Rect(800, 300, 500, 500), labelText);
    }
}
