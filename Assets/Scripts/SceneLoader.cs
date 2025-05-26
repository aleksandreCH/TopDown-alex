using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    [SerializeField] GameObject gameUI;
    [SerializeField] GameObject gameOverUI;



    public void LoadGameScene()
    {
        SceneManager.LoadScene("game");
    }
    public void LoadGameOverUI()
    {
        gameUI.SetActive(false);
        gameOverUI.SetActive(true);
    }



}
