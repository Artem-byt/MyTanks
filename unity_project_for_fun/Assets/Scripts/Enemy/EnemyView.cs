using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyView : MonoBehaviour
{
    public event Action<GameObject> OnClickTank;


    public void OnMouseDown()
    {
        Debug.Log("PressedOnEnemy");
        OnClickTank?.Invoke(gameObject);
    }
}
