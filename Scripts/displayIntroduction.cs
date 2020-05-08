using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayIntroduction : MonoBehaviour
{
    public GameObject introCanvas;

    void OnTriggerEnter(Collider obj) 
    {
        if(obj.tag=="Player"){
            Debug.Log("introduce the island");
            introCanvas.SetActive(true);
            GameObject content1 = introCanvas.transform.Find("content1").gameObject;
            content1.SetActive(true);
            Destroy(this.gameObject);
        } 
    }
}
