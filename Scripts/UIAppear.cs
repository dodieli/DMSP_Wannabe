using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear : MonoBehaviour
{
    [SerializeField] private Image customImage;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && (count.tik_tok+count.weibo+count.facebook) == 14)
        {
            customImage.enabled = true;
        }
    }
        void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            customImage.enabled = false;
        }
    }
}
