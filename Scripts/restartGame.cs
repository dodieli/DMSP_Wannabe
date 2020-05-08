using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitRestart());
    }

    IEnumerator waitRestart()
    {
    	yield return new WaitForSeconds(61);
    	SceneManager.LoadScene (0);
    }
}
