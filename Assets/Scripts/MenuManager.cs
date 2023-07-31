using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    private string input;

    //GameObjects
    public GameObject HighScoreName;
    public GameObject HighScore;
    
    //Game Variables
    public string pName;
    public int pScore;

    //Text Components
    Text pName_text;
    Text score_text;
    
    // Start is called before the first frame update
    void Start()
    {
        pName_text = HighScoreName.GetComponent<Text>();
        score_text = HighScore.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        pName_text.text = "High Score : " + pName;
        score_text.text = pScore.ToString();


    }
    public string GetName()
    {
        return pName_text.text;
    }
    public string GetScore()
    {
        return score_text.text;
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
        //MainManager.Instance.SaveColor();
    }
    public void ReadInput(string s)
    {
        pName = s;
        Debug.Log(pName);
    }
}
