using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        pName_text.text = pName;
        score_text.text = pScore.ToString();


    }

    public void ReadInput(string s)
    {
        pName = s;
        Debug.Log(pName);
    }
}
