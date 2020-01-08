using UnityEngine;

public class SlerpPosition : MonoBehaviour
{
    public Vector3 from = new Vector3 (-2.5f, 0f, 0f);
    public Vector3 to = new Vector3 (2.5f, 0f, 0f);
    
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, to, 0.75f * Time.deltaTime);
    }
}
