using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IDContainerBehaviour : MonoBehaviour
{
    public ID idObj;

    public UnityEvent startEvent;

    private void Start()
    {
        startEvent.Invoke();
    }
}
