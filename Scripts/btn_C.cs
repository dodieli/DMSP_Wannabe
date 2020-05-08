using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn_C : MonoBehaviour
{
	public GameObject question;

	public void onCLick(int num)
	{
		GameObject questionCanvas = question.transform.parent.gameObject;
		questionCanvas.SetActive(false);
		question.SetActive(false);
        Debug.Log("click C");

        int i = count.answerList[num, 2];

		switch(i)
		{
			case 0:
				count.tik_tok++;
				break;
			case 1:
				count.weibo++;
				break;
			case 2:
				count.facebook++;
				break;
		}
		
		if(num < 5 && num > -1){
			count.questionsAnsweredNum += (num+1).ToString() + " ";
		}
		else if(num == 5){
			count.questionsAnsweredNum += "7 ";
		}
		else if(num == 6){
			count.questionsAnsweredNum += "9 ";
		}
		else if(num < 11){
			count.questionsAnsweredNum += (num+4).ToString() + " ";
		}
	}
}
