using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

namespace Lovatto.SceneLoader.Editor
{
    [InitializeOnLoad]
    class bl_LoadingScreenStartUp
    {

        private const string ONE_TIME_KEY = "lovatto.loadingscreen.startup";

        static bl_LoadingScreenStartUp()
        {
            if (PlayerPrefs.GetInt(ONE_TIME_KEY, 0) == 0)
            {
                EditorApplication.update += Update;
            }
        }

        [MenuItem("Window/Lovatto/Loading Screen/Add Levels")]
        public static void SetupLevelsOption()
        {
            Setup();
        }

        [MenuItem("Window/Lovatto/Loading Screen/Documentation")]
        public static void OpenDocumentation()
        {
            Application.OpenURL("http://lovattostudio.com/documentations/loading-screen/");
        }

        /// <summary>
        /// 
        /// </summary>
        static void Update()
        {
            PlayerPrefs.SetInt(ONE_TIME_KEY, 1);
            EditorApplication.update -= Update;

            bl_LoadingScreenWelcome.ShowWindow();
            Setup();
      
        }

        /// <summary>
        /// 
        /// </summary>
        static void Setup()
        {
            bl_SceneLoaderManager sm = Resources.Load("SceneLoaderManager", typeof(bl_SceneLoaderManager)) as bl_SceneLoaderManager;
            if (sm == null) { Debug.Log("Can't load scenes"); return; }

            string[] allscenes = SceneNames();
            List<bl_SceneLoaderInfo> scenes = new List<bl_SceneLoaderInfo>();
            scenes.AddRange(sm.List.ToArray());
            for (int i = 0; i < allscenes.Length; i++)
            {
                if (scenes.Exists(x => x.SceneName == allscenes[i])) { continue; }
                bl_SceneLoaderInfo info = new bl_SceneLoaderInfo();
                info.SceneName = allscenes[i];
                info.DisplayName = allscenes[i];

                sm.List.Add(info);
            }
            Debug.Log("Scenes setup with success!");

            Selection.objects = new UnityEngine.Object[] { sm };
            EditorGUIUtility.PingObject(sm);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string[] SceneNames()
        {
            List<string> temp = new List<string>();
            foreach (EditorBuildSettingsScene S in EditorBuildSettings.scenes)
            {
                if (S.enabled)
                {
                    string name = S.path.Substring(S.path.LastIndexOf('/') + 1);
                    name = name.Substring(0, name.Length - 6);
                    temp.Add(name);
                }
            }
            return temp.ToArray();
        }
    }
}