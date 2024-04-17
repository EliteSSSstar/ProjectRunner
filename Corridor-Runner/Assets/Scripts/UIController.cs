using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
   public void Play()
   {
        SceneController.LoadScene(1);
   }

   public void Restart()
   {
     SceneController.Restart();
   }

   public void NextLevel()
   {
        SceneController.NextLevel();
   }

   public void SceneLoad(int sceneIndex)
   {
         SceneController.LoadScene(sceneIndex);
   }
   public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
          // Deactivate the GUI panel after quitting the game
          // guiPanel.SetActive(false);
        #endif
    }
}
