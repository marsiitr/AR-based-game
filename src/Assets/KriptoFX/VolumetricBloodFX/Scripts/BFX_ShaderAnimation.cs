using UnityEngine;
using System.Collections;

public class BFX_ShaderAnimation : MonoBehaviour {

    public BFX_BloodSettings BloodSettings;

    public AnimationCurve FloatCurve = AnimationCurve.EaseInOut(0, 0, 1, 1);
    public float GraphTimeMultiplier = 1, GraphIntensityMultiplier = 1;
    public bool IsLoop;
    public int MaterialNumber = 0;
    public bool UseSharedMaterial;
    public Renderer[] UseSharedRenderers;
    public float TimeDelay = 0;

    private bool canUpdate;
    private float startTime;

    private int propertyID;
    private string shaderProperty;


    private MaterialPropertyBlock props;
    private Renderer rend;

    private void Awake()
    {
        props = new MaterialPropertyBlock();
        rend = GetComponent<Renderer>();

        propertyID = Shader.PropertyToID("_Cutout");

        OnEnable();
    }

    private void OnEnable()
    {
        startTime = Time.time + TimeDelay;
        canUpdate = true;

        rend.GetPropertyBlock(props);

        var eval = FloatCurve.Evaluate(0) * GraphIntensityMultiplier;
        props.SetFloat(propertyID, eval);

        rend.SetPropertyBlock(props);
    }

    private void OnDisable()
    {
        rend.GetPropertyBlock(props);

        var eval = FloatCurve.Evaluate(0) * GraphIntensityMultiplier;
        props.SetFloat(propertyID, eval);

        rend.SetPropertyBlock(props);
    }



    private void Update()
    {
        rend.GetPropertyBlock(props);

        var time = Time.time - startTime;
        if (canUpdate)
        {

            if (BloodSettings != null && BloodSettings.DecalLiveTimeInfinite && (time / GraphTimeMultiplier) > 0.3f) props.SetFloat(propertyID, 0);
            else
            {
                var eval = FloatCurve.Evaluate(time / GraphTimeMultiplier) * GraphIntensityMultiplier;
                props.SetFloat(propertyID, eval);
            }
            if (BloodSettings != null) props.SetFloat("_LightIntencity", Mathf.Clamp(BloodSettings.LightIntensityMultiplier, 0.01f, 1f));
        }
        if (time >= GraphTimeMultiplier)
        {
            if (IsLoop) startTime = Time.time;
            else canUpdate = false;
        }

        rend.SetPropertyBlock(props);
    }

}
