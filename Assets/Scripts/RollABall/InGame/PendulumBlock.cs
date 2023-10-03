using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PendulumBlock : MonoBehaviour
{
    public float Amplitude = 5f;
    public float Frequency = 1f;
    private Vector3 startPos = Vector3.zero;

    /// <summary>
    /// Unity上でポリゴンを表示するクラス
    /// </summary>
    private MeshRenderer boxMesh;
    float time = 1.0f;

    private void Start()
    {
        startPos = transform.position;
        // Start時点で代入して
        boxMesh = GetComponent<MeshRenderer>();
    }
    void Update()
    {
        transform.position = startPos + Vector3.forward * Amplitude * Mathf.Sin(Time.time * Frequency);
        // 1秒からデルタタイムを減らしていく
        time -= Time.deltaTime;
        if (time < 0f)
        {
            // BoxMeshの表示を、現在の表示の反対に代入する
            boxMesh.enabled = !boxMesh.enabled;
            time = 1f;
        }
    }
}
