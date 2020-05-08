using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class count : MonoBehaviour
{
    public static int tik_tok = 0;
    public static int weibo = 0;
    public static int facebook = 0;
    public GameObject text_content;
    public static int[,] answerList = new int[11,3]{
        {2, 1, 0},
        {0, 1, 2},
        {2, 1, 0},
        {0, 1, 2},
        {0, 1, 2},
        {0, 1, 2},
        {0, 1, 2},
        {0, 1, 2},
        {0, 1, 2},
        {0, 1, 2},
        {1, 2, 0}    };
    public static string questionsAnsweredNum = "";

    // Update is called once per frame
    void Update()
    {
        string text_string = "Weibo: " + weibo + "\n" + "TikTok: " + tik_tok + "\n" + "Facebook: " + facebook + "\n" + "Questions Answered: " + questionsAnsweredNum + "\n";
        text_content.GetComponent<TMP_Text>().text = "<size=36><color=white>" + text_string + "</color></size>";

    }
}
