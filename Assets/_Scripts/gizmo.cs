﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gizmo : MonoBehaviour {

    public float gizmoSize = 0.75f;
    public Color gizmoColor = Color.magenta;

    private void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        Gizmos.DrawWireSphere(transform.position, gizmoSize);
    }
}
