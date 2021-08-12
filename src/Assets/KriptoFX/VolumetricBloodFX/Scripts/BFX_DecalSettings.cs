
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BFX_DecalSettings : MonoBehaviour
{
    public BFX_BloodSettings BloodSettings;
    public Transform parent;
    public float TimeHeightMax = 3.1f;
    public float TimeHeightMin = -0.1f;
    [Space]
    public Vector3 TimeScaleMax = Vector3.one;
    public Vector3 TimeScaleMin = Vector3.one;
    [Space]
    public Vector3 TimeOffsetMax = Vector3.zero;
    public Vector3 TimeOffsetMin = Vector3.zero;
    [Space]
    public AnimationCurve TimeByHeight = AnimationCurve.Linear(0, 0, 1, 1);

    private Vector3 startOffset;
    private Vector3 startScale;
    private Vector3 anchorPos;
    private float timeDelay;
    Vector3 averageRay;

    Transform t, tParent;
    BFX_ShaderAnimation shaderCurve;
    private void Awake()
    {
        startOffset = transform.localPosition;
        startScale = transform.localScale;
        t = transform;
        tParent = parent.transform;
        shaderCurve = GetComponent<BFX_ShaderAnimation>();
    }

    void OnEnable()
    {
        var currentHeight = parent.position.y;
        var ground = BloodSettings.Height;

        var currentScale = parent.localScale.y;
        var scaledTimeHeightMax = TimeHeightMax * currentScale;
        var scaledTimeHeightMin = TimeHeightMin * currentScale;

        if (currentHeight - ground >= scaledTimeHeightMax || currentHeight - ground <= scaledTimeHeightMin)
        {
            GetComponent<MeshRenderer>().enabled = false;
        }
        else
        {
            GetComponent<MeshRenderer>().enabled = true;
        }

        float diff = (tParent.position.y - ground) / scaledTimeHeightMax;
        diff = Mathf.Abs(diff);

        var scaleMul = Vector3.Lerp(TimeScaleMin, TimeScaleMax, diff);
        t.localScale = new Vector3(scaleMul.x * startScale.x, startScale.y, scaleMul.z * startScale.z);

        var lastOffset = Vector3.Lerp(TimeOffsetMin, TimeOffsetMax, diff);
        t.localPosition = startOffset + lastOffset;
        t.position = new Vector3(t.position.x, ground + 0.05f, t.position.z);
        anchorPos = t.position;

        timeDelay = TimeByHeight.Evaluate(diff);

        shaderCurve.enabled = false;
        Invoke("EnableDecalAnimation", timeDelay);

        /*
        averageRay = GetAverageRay(tParent.position + tParent.right * 0.05f, tParent.right);

        float decalAngle = Vector3.Angle(Vector3.up, averageRay);
        var zRotation = Mathf.Clamp(decalAngle, -90, 90);
        var decalRotation = t.localRotation.eulerAngles;
        t.localRotation = Quaternion.Euler(decalRotation.x, decalRotation.y, zRotation * 0.5f);

        var scaleRelativeToAngle = zRotation / 90f;
        var decalScale = t.localScale;
        decalScale.y = Mathf.Lerp(decalScale.y, decalScale.y * 4, scaleRelativeToAngle);

        t.localScale = decalScale;
        */
    }

    Vector3 GetAverageRay(Vector3 start, Vector3 forward)
    {
        if (Physics.Raycast(start, -forward, out RaycastHit bulletRay))
        {
            return (bulletRay.normal + Vector3.up).normalized;
        }

        return Vector3.up;
    }

    void EnableDecalAnimation()
    {
        shaderCurve.enabled = true;
    }

    private void OnDrawGizmos()
    {
        if (t == null) t = transform;
        Gizmos.color = new Color(49 / 255.0f, 136 / 255.0f, 1, 0.15f);
        Gizmos.matrix = Matrix4x4.TRS(t.position, t.rotation, t.lossyScale);
        Gizmos.DrawCube(Vector3.zero, Vector3.one);

        Gizmos.color = new Color(49 / 255.0f, 136 / 255.0f, 1, 0.95f);
        Gizmos.DrawWireCube(Vector3.zero, Vector3.one);

        Gizmos.matrix = Matrix4x4.identity;
        Gizmos.color = new Color(0.95f, 0.2f, 0.2f, 0.85f);
        Gizmos.DrawRay(t.position, averageRay);

    }
}
