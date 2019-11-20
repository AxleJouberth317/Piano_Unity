using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnClickKey : MonoBehaviour
{
    Material mat;
    Renderer rend;
    public Material redNeon;
    [SerializeField] UnityEvent anEvent;

    private void OnMouseDown() => anEvent.Invoke();
    public KeyCode key;

    private void Start()
    {
        rend = this.GetComponent<Renderer>();
        mat = rend.material;
    }
    private void Update()
    {
        if (Input.GetKeyDown(key))
        {
            anEvent.Invoke();
            rend = this.GetComponent<Renderer>();
            rend.material = redNeon;
        }
        if (Input.GetKeyUp(key))
        {
            rend = this.GetComponent<Renderer>();
            rend.material = mat;
        }
    }
}