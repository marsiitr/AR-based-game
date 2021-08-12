Version 1.0.1

My email is "kripto289@gmail.com"
Discord Kripto#6346
You can contact me for any questions.
My English is not very good, and if I have any translation errors, you can write me :)


Package includes 17 prefabs of the blood effects (blood mesh + decal) and prefab for shot point decal.
Support platforms: all platforms (PC/Consoles/VR/Mobiles/URP/HDRP)

------------------------------------------------------------------------------------------------------------------------------------------
IMPORTANT

For all platforms required format "RGBA half" or compressed "RGB9e5 23 bit Shared Exponent Float" for textures with the name "blood_norm" and "blood_pos"
RGB9e5 this is a lossy format so the blood drops will be sharper.

For mobile devices you must to do "texture overide for android -> RGBA half/RGB9e5", because by default unity used RGBM encoding for android and this format does not work correctly.

For HDRP and URP you need to import patches from the folder "\Assets\KriptoFX\VolumetricBloodFX\URP and HDRP Patches"

For correct rendering of screen space decals you need:
    -For STANDARD FORWARD: MainCamera -> Add the script "BFX_RenderDepth"
    -For URP rendering mainCamera -> DepthTexture = ON
    -For HDRP depth rendering works by default
------------------------------------------------------------------------------------------------------------------------------------------
Effect optimisations:

1) You can change texture format for textures with the name "blood_norm" and "blood_pos".
Click on current platform (not a "default" tab!) -> override for "current platform name" -> select format "RGB9e5 23 bit Shared Exponent Float"
This format available with unity 2019.x+. Visual quality will suffer a little bit.

2) You can decrease height of decals. The decals is drawn in the form of a cube. Smaller the height of the cube -> the less pixels are drawn.
Open blood prefab -> select decal -> change transform "y"

3) You can remove shadows and depth writing. With directional light and depth rendering you can decrease number of triangles x4 times!
Open BFX_Blood shader -> find ths lines "//start remove line " and "//end remove light"
Remove the code from the "start" to "end" lines. (150 -> 231 line number)

4) Use lower resolution for mobile devices :)
Do you really need to render the game in 2-4k on screen with size 5-7 inches?? Even not many pc games can work in 4k. I find this unnecessary.
For example
Screen.SetResolution((int)(Screen.width * 0.5f), (int)(Screen.height * 0.5f), FullScreenMode.ExclusiveFullScreen, 60);

------------------------------------------------------------------------------------------------------------------------------------------
Effect settings:

For scaling just change a prefab transform scale.

You can draw decals for only some layers.
For that just add the script "BFX_RenderDepth" on the main camera and select a layers for decal drawing.
But this method has overhead since the selected layers need to be drawn in the depth buffer


Each prefab of a blood (blood1 - blood 15) have the attached script "BFX_BloodSettings"

1) Height
It's your ground height.

2) LightIntensityMultiplier [0 - 1]
Brightness intensity  of blood and light glare. For day light use 1, for night use 0, etc.

3) DecalLiveTimeInfinite
Default animation of blood (include decal fadeout) ~15 second.
You can change it for infinite time of decals.

.

------------------------------------------------------------------------------------------------------------------------------------------

Effects using:

1)
The blood should be rotated to the right angle.
Since the animation is baked and gravity must flow down. If you turn the effect up (for example) then the gravity animation will flow left/right.
So, instead of using "Insatiate(bloodPrefab);" you need to use similar code:

var direction = .... //you must assign the direction, for example Physics.Raycast(ray, out hit); direction = hit.normal;
float angle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + 180;
var instance = Instantiate(bloodPrefab, hit.point, Quaternion.Euler(0, angle + 90, 0));

2)
Remove the blood effects when a animation will be finished and the prefab->BFX_BloodSettings->"Decal Life Time Infinite = false"
Destroy(instance, 20);

3)
Decal at the shot point (for example, on the character) may have problems with moved object.
Unfortunately, there is no way to add a blood decal withoit visible arefacts to any object with different shaders and different UV.
Therefore, the only method is to attach the decal to the bone or to the object. But this will produce visual artifacts (when the decal moves separately from the mesh).

I use follow code for find nearest bone in the hit point:

Transform GetNearestObject(Transform hit, Vector3 hitPos)
{
    var closestPos = 100f;
    Transform closestBone = null;
    var childs = hit.GetComponentsInChildren<Transform>();

    foreach (var child in childs)
    {
        var dist = Vector3.Distance(child.position, hitPos);
        if (dist < closestPos)
        {
            closestPos = dist;
            closestBone = child;
        }
    }

    var distRoot = Vector3.Distance(hit.position, hitPos);
    if (distRoot < closestPos)
    {
        closestPos = distRoot;
        closestBone = hit;
    }
    return closestBone;
}

In the next code I rotate the decal by normal of shot point.
For example I use left mouse click for instantiate blood effect on a surface

if (Input.GetMouseButtonDown(0))
{
    var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;
    if (Physics.Raycast(ray, out hit))
    {
        var nearestBone = GetNearestObject(hit.transform.root, hit.point);
        if(nearestBone == null) return;

        var attachedBloodInstance = Instantiate(attachedBloodDecal, nearestBone);
        var bloodT = attachedBloodInstance.transform;
        bloodT.position = hit.point;
        bloodT.localRotation = Quaternion.identity;
        bloodT.LookAt(hit.point + hit.normal, direction);
        bloodT.Rotate(90, 0, 0);
        Destroy(attachBloodInstance, 20);
    }
}
