using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeWbutton : MonoBehaviour
{
//comment milad
   public void ButtonMoveScene(string sceneName)
   {
    SceneManager.LoadScene(sceneName) ;
   }
   
}
