using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class screen_contrl : MonoBehaviour
{
	public GameObject Canvas_choose;
	public int video_num;
	public static bool[] flag = new bool[3] {false, false, false};
    VideoPlayer videoPlayer;
    bool stayInArea = false;

    void Start()
    {
        videoPlayer = this.GetComponent<VideoPlayer>();
        videoPlayer.playOnAwake = false;
    }

    void OnMouseDown()
    {
        if(stayInArea)
        {
            if (!videoPlayer.isPlaying)
            {
                Debug.Log("Play the video");
                videoPlayer.Play();
            } 
            else
            {
                Debug.Log("Pause the video");
                videoPlayer.Pause();
            }
        }  	
	}

	void OnTriggerEnter(Collider obj) 
    {
        stayInArea = true;
        if(obj.tag=="Player" && flag[video_num]==false){
            Canvas_choose.SetActive(true);
            btn_videoChoices.video_num = video_num;
        } 
        if (!videoPlayer.isPlaying)
        {
            Debug.Log("Play the video");
            videoPlayer.Play();
        }
    }

    void OnTriggerStay(Collider obj)
    {
    	if(obj.tag=="Player" && flag[video_num]==true){
            stayInArea = true;
    		Canvas_choose.SetActive(false);
    		btn_videoChoices.video_num = -1;
    	}
    }

    void OnTriggerExit(Collider obj)
    {
    	if(obj.tag=="Player"){
            stayInArea = false;
            Canvas_choose.SetActive(false);
            btn_videoChoices.video_num = -1;
        } 
        if (videoPlayer.isPlaying)
        {
            Debug.Log("Pause the video");
            videoPlayer.Pause();
        }
    }

}
