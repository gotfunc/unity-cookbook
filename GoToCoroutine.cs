using UnityEngine;
using System.Collections;

public class GoToCoroutine : MonoBehaviour {

    void Update ()
    {
        if (Input.GetKeyDown("right"))
        {
            StartCoroutine(IGoTo(new Vector3(2.5f, 0, 0), 5f));
        }
    }

    IEnumerator IGoTo(Vector3 direction, float speed)
    {
        float time = Time.time;
        Vector3 from = transform.position; // Start position
        Vector3 to = transform.position + direction; // End position

        while (from != to)
        {
            yield return transform.position = Vector3.Lerp(transform.position, direction, speed * Time.deltaTime);
        }
    }
}
