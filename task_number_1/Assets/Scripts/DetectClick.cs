using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectClick : MonoBehaviour
{
    public SpawnCubs SpawnCubsScript;

    private void OnMouseDown()
    {
        SpawnCubsScript.CreatingCubes();
    }
}

