using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class videoControl : MonoBehaviour
{
    public GameObject Canvas;

    void Start()
    {
        Canvas.SetActive(false);
        StartCoroutine(waitDestroy());
    }

    void OnGUI() {
        Event e = Event.current;
        if (e.isKey){
        	Destroy(this.gameObject);
            Canvas.SetActive(true);
        	Debug.Log("skip the introductory video");
        }      
    }

    IEnumerator waitDestroy(){
        yield return new WaitForSeconds(68);
        Canvas.SetActive(true);
        Destroy(this.gameObject);
    }
}
