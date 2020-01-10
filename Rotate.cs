using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Vector3 _rotation;
    private float _speed = 0;

    void Start()
    {
        if (! rotation)
            _rotation = new Vector3(RandFloat(), RandFloat(), RandFloat());

        _speed = RandFloat() * 20;
    }

    float RandFloat()
    {
        return Random.Range(0f, 1f);
    }

    void FixedUpdate()
    {
        transform.Rotate(_rotation, _speed * Time.smoothDeltaTime);
    }
}
