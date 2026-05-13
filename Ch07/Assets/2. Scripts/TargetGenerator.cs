using System;
using UnityEngine;

public class TargetGenerator : MonoBehaviour
{
    public GameObject targetPrefab;
    public float minDistance = 10f;
    Transform[]targetPositions;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetPositions = GetComponentsInChildren<Transform>();
    }

    public void GenerateTarget(Vector3 PlayerPosition)
    {
        do
    {
    Index = Random.Range(1,TargetPosition.Length);
    } while(
    Vector3.Distance(PlayerPosition, TargetPosition[Index].position)<minDistance);
        Vector3 position = TargetPosition[Index].position;
        GameObject.target = Instantiate(targetPrefab, position, Quaternion.identity);

        target.transform.SetParent(transform);  
    }
}
