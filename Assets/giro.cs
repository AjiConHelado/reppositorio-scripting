using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giro : MonoBehaviour
{
    [SerializeField]public float rotationRate;
    private Transform _transform;
    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("Awake");
        _transform = transform;
    }
    private void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
        _transform.Rotate(0f,30f*Time.deltaTime,0f);
    }
    private void OndeStroy()
    {
        Debug.Log("OnDestroy");
    }
}
