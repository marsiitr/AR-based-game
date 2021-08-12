using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Demo : MonoBehaviour 
{
#if UNITY_EDITOR
	private void OnGUI()
	{
		float size = 8;
		float btnSize = Screen.height / size;

		AnimationClip[] clips = AnimationUtility.GetAnimationClips(gameObject);
		Animation anim = GetComponent<Animation>();
		
		for(int i = 0; i < clips.Length; ++i)
		{
			int col = (int)(i / size);
			if(GUI.Button(new Rect(btnSize * col, (i - col * size) * btnSize, btnSize, btnSize), clips[i].name))
			{
				anim.CrossFade(clips[i].name, 0.2f);
			}
		}
	}
#endif
}
