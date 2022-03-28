using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public GameControl control;
    void Update()
    {
        transform.Translate(0, 0, control.objectSpeed);
    }
}
