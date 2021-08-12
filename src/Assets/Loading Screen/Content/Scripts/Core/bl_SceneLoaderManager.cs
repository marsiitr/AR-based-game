using UnityEngine;
using System.Collections.Generic;

namespace Lovatto.SceneLoader
{
    public class bl_SceneLoaderManager : ScriptableObject
    {

        [Header("Scene Manager")]
        [Reorderable(elementNameProperty = "myString")]
        public TheSceneList List;

        [Header("Tips"), Reorderable("Tips")]
        public TheTipList TipList;

        public bl_SceneLoaderInfo GetSceneInfo(string scene)
        {
            foreach(bl_SceneLoaderInfo info in List)
            {
                if(info.SceneName == scene)
                {
                    return info;
                }
            }
            
            Debug.Log("Not found any scene with this name: " + scene);
            return null;           
        }

        public bool HasTips
        {
            get
            {
                return (TipList != null && TipList.Count > 0);
            }
        }
    }
}