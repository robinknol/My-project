using System;
using UnityEngine;

public class ShaderChanger : MonoBehaviour
{
    [SerializeField] private Material material;
    private float _minVertex = -0.5f;
    private float _maxVertex = 0;
    private float _currentVertex;

    private void Awake()
    {
        _currentVertex = _maxVertex;
    }

    private void Update()
    {
        material.SetFloat("temp", _currentVertex);
        
        if (_currentVertex > _maxVertex)
        {
            _currentVertex = _maxVertex;
        }
        else if (_currentVertex < _minVertex)
        {
            _currentVertex = _minVertex;
        }
        else
        {
            _currentVertex -= Time.deltaTime / 55;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _currentVertex = _maxVertex;
    }
}
