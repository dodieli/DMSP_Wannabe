using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePosition : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform point;


    void OnTriggerEnter(Collider other)
    {
        
            player.transform.position = point.transform.position;
       

        

    }


}
