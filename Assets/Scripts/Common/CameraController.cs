using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField]
    private Camera _camera;

    [SerializeField]
    private float _shakePower;

    private float _timer;
    private Vector3 _startPosition;

    // Use this for initialization
    void Start () {
        _camera = Camera.main;
        _startPosition = _camera.transform.position;
        _timer = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
            _timer = _shakePower;
        if (_timer > 0)
        {
            ShakeCamera(_timer);
            _timer -= Time.deltaTime * 2;
        }
        if (_timer <= 0)
            _camera.transform.localPosition = _startPosition;
    }

    private void ShakeCamera(float shakePower)
    {
        transform.localPosition = new Vector3(Random.Range(-shakePower, shakePower), Random.Range(-shakePower, shakePower), transform.localPosition.z);
    }
}
