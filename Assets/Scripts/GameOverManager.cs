using UnityEngine;
using System.Collections;

public class GameOverManager : MonoBehaviour
{

    void Start()
    {
        
    }

   void Update()
    {

    }

    public void ChangeScene(string sceneToChange)
    {
        Application.LoadLevel(sceneToChange);
    }

}
