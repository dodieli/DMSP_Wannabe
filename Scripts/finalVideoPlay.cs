using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class finalVideoPlay : MonoBehaviour
{

	public GameObject canvas_game;
	public GameObject canvas_video;
	VideoPlayer video_tiktok;
	VideoPlayer video_facebook;
	VideoPlayer video_weibo;

	int tik_tok;
	int weibo;
	int facebook;
	bool flag = false;

	void Start()
	{
		float num = Random.Range(1, 8);
		if(num > 4.0f) { flag = true; }
        
        video_tiktok = canvas_video.transform.Find("tiktok").gameObject.GetComponent<VideoPlayer>();
        video_facebook = canvas_video.transform.Find("facebook").gameObject.GetComponent<VideoPlayer>();
        video_weibo = canvas_video.transform.Find("weibo").gameObject.GetComponent<VideoPlayer>();
	}

    void OnTriggerEnter(Collider obj) 
    {
        if(obj.tag=="Player"){
        	tik_tok = count.tik_tok;
        	weibo = count.weibo;
        	facebook = count.facebook;

            canvas_game.SetActive(false);
            canvas_video.SetActive(true);

            if(facebook >= weibo && facebook >= tik_tok){
            	if(facebook == weibo){
            		if(flag) { video_facebook.Play(); } else { video_weibo.Play(); }
            	}
            	else if(facebook == tik_tok){
            		if(flag) { video_facebook.Play(); } else { video_tiktok.Play(); }
            	}
            	else{
            		video_facebook.Play();
            	}
            }

            else if(weibo >= facebook && weibo >= tik_tok){
            	if(weibo == facebook){
            		if(flag) { video_weibo.Play(); } else { video_facebook.Play(); }
            	}
            	else if(weibo == tik_tok){
            		if(flag) { video_weibo.Play(); } else { video_tiktok.Play(); }
            	}
            	else{
            		video_weibo.Play();
            	}
            }

            else if(tik_tok >= facebook && tik_tok >= weibo){
            	if(tik_tok == facebook){
            		if(flag) { video_tiktok.Play(); } else { video_facebook.Play(); }
            	}
            	else if(tik_tok == weibo){
            		if(flag) { video_tiktok.Play(); } else { video_weibo.Play(); }
            	}
            	else{
            		video_tiktok.Play();
            	}
            }
        } 
    }

}
