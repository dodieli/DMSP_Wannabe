using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayAnimation: MonoBehaviour
{
	[SerializeField] private Animator anim;

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			anim.SetBool("PlayAnimation", true);

		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			anim.SetBool("PlayAnimation", false);

		}
	}
}
