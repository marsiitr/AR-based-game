using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingScript : MonoBehaviour
{
    int _rotationSpeed = -500;

    void Update()
    {

        // Rotation on y axis
        transform.Rotate(0, 0, _rotationSpeed * Time.deltaTime);
    }
}
