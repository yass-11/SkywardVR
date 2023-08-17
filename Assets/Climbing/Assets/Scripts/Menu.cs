using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public RectTransform MainMenu;

    public RectTransform DifficultyMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetDifficulty(int diff){
        PlayerPrefs.SetInt("Difficulty", diff);
        switch(diff){
            case 1:
                SceneManager.LoadScene("Climbing");
                break;
            case 2:
                SceneManager.LoadScene("Level2");
                break;
            default:
                SceneManager.LoadScene("Level3");
                break;
        }
    }

    public void ShowDifficultyMenu(){
        MainMenu.gameObject.SetActive(false);
        DifficultyMenu.gameObject.SetActive(true);
    }

    public void HideDifficultyMenu(){
        MainMenu.gameObject.SetActive(true);
        DifficultyMenu.gameObject.SetActive(false);
    }

    public void ExitGame(){
        Application.Quit();
    }
    public void StartGame(){
        SceneManager.LoadScene("Level1");
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
