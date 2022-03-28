using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBytime : MonoBehaviour
{
    public float lifetime;
    void Start()
    {
        Destroy(gameObject, lifetime);
    }

}
