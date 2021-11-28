using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PLayerView : MonoBehaviour
{
    public event Action<GameObject> OnClickTank;


    public void OnMouseDown()
    {
        Debug.Log("Pressed");
        OnClickTank?.Invoke(gameObject);
    }
}
