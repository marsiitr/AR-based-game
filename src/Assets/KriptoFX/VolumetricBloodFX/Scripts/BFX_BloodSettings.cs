using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BFX_BloodSettings : MonoBehaviour
{
    public float Height = 0;
    [Range(0, 1)]
    public float LightIntensityMultiplier = 1;
    public bool DecalLiveTimeInfinite = false;
}
