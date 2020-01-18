using UnityEngine;
using UnityEngine.AI;

public class NavMeshBaker : MonoBehaviour
{
    void Awake() => GetComponent<NavMeshSurface>().BuildNavMesh();
}
