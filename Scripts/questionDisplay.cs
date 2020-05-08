using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questionDisplay : MonoBehaviour
{
	public GameObject question;
	bool flag = false;
	float timer = 0;

	void Update()
	{
		if(!flag){
			timer = Time.time;
		}
		
		if(flag){
			if(Time.time - timer >= 3)
			{
				Debug.Log("question");
				GameObject questionCanvas = question.transform.parent.gameObject;
				questionCanvas.SetActive(true);
				question.SetActive(true);
				flag = true;
				Destroy(this);
			}
		}
	}

	// void OnMouseDown()
	// {
	// 	flag = true;
	// }

	void OnTriggerEnter(Collider obj)
	{
		if(obj.tag=="Player"){
			flag = true;
			Debug.Log(flag);
		}
	}

}
