using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    bool BTouch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseUpAsButton()
    {
        if (BTouch == false)
        {
            BTouch = true;
            GameObject gameObject1 = GameObject.FindGameObjectWithTag("Player");
            gameObject1.GetComponent<Animator>().SetBool("Touch", true);
            Debug.Log("11");
            Invoke("EndAni", 0.5f);
        }
    }
    public void EndAni()
    {
        if (BTouch == true)
        {
            BTouch = false;
            GameObject gameObject1 = GameObject.FindGameObjectWithTag("Player");
            gameObject1.GetComponent<Animator>().SetBool("Touch", false);
        }
    }
}
