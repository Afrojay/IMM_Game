
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
public void ExitButton0) {
    Application.Quit();
    Debug.Log("Game closed");
}
public void StartGame()
{
    SceneManager.LoadScence("Game");
}
}
