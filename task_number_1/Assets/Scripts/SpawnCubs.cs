using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubs : MonoBehaviour
{
    public static SpawnCubs SpawnCubsScript;
    public GameObject cube_prefab;
    public int number_cubes = 2;

    private void Awake()
    {
        SpawnCubsScript = this;
    }

    public void CreatingCubes()
    {
        for(int i = 0; i < number_cubes; i++)
        Instantiate(cube_prefab, transform.position, Quaternion.identity);
    }

}
