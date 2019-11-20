using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnClickKey : MonoBehaviour
{

    [SerializeField] UnityEvent anEvent;

    private void OnMouseDown() => anEvent.Invoke();
}