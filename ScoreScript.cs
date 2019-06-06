using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    Text ScoreText;
    public static int Score;
    void Start()
    {
        Score = 0;
        ScoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score : " + Score;
        if(Score==4){
                SceneManager.LoadScene(0);
                Debug.Log("4");
            }
    }
}
