using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn_videoChoices : MonoBehaviour
{
	public static int video_num = -1;

	public void onCLick(int btn_num)
	{
		switch(btn_num)
		{
			case 0:
				count.facebook++;
				break;
			case 1:
				count.weibo++;
				break;
			case 2:
				count.tik_tok++;
				break;
		}
		screen_contrl.flag[video_num] = true;

		switch(video_num)
		{
			case 0:
				count.questionsAnsweredNum += "10 ";
				break;
			case 1:
				count.questionsAnsweredNum += "8 ";
				break;
			case 2:
				count.questionsAnsweredNum += "6 ";
				break;
		}
	}
}
