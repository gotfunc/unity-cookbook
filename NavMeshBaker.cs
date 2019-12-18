using UnityEngine;
using UnityEngine.AI;

public class NavMeshBaker : MonoBehaviour
{
    public NavMeshSurface surface;

    void Start() => surface.BuildNavMesh();
}
