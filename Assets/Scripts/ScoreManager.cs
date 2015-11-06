using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;

    void OnGUI()
    {
        GUILayout.Label("Score: " + score.ToString());
        //Debug.Log("Score made it here");
    }
}

