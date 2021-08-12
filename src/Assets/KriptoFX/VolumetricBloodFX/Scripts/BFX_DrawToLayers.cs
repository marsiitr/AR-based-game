using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BFX_DrawToLayers : MonoBehaviour
{
    public LayerMask DrawDecalToLayers = 1;

    DepthTextureMode defaultMode;
    RenderTexture rt;

    void Start()
    {
        var currentCam = GetComponent<Camera>();
        defaultMode = currentCam.depthTextureMode;
        if (currentCam.renderingPath == RenderingPath.Forward)
        {
            currentCam.depthTextureMode |= DepthTextureMode.Depth;
        }

        var go = new GameObject("DecalLayersCamera");
        go.transform.parent = currentCam.transform;
        go.transform.localPosition = Vector3.zero;
        go.transform.localRotation = Quaternion.identity;
        var cam = go.AddComponent<Camera>();
        cam.CopyFrom(currentCam);
        cam.renderingPath = RenderingPath.Forward;
        cam.depth = cam.depth - 1;
        cam.cullingMask = DrawDecalToLayers;

        rt = new RenderTexture(Screen.width, Screen.height, 24, RenderTextureFormat.Depth);
        cam.targetTexture = rt;
        Shader.SetGlobalTexture("_LayerDecalDepthTexture", rt);
        Shader.EnableKeyword("USE_CUSTOM_DECAL_LAYERS");
    }

    void OnDisable()
    {
        GetComponent<Camera>().depthTextureMode = defaultMode;
        rt.Release();
        Shader.DisableKeyword("USE_CUSTOM_DECAL_LAYERS");
    }
}
