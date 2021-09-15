﻿using UnityEngine;

public class TerrainTemplate : MonoBehaviour
{
    private const float debugLineHeight = 10.0f;

    private void OnDrawGizmos()
    {
        Debug.DrawLine(transform.position + Vector3.up * debugLineHeight / 2, transform.position + Vector3.down * debugLineHeight / 2, Color.green);
    }
}
