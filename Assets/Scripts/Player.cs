using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float _speed;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            _rigidbody.velocity = Vector3.forward * _speed;
        else if (Input.GetKey(KeyCode.DownArrow))
            _rigidbody.velocity = Vector3.back * _speed;
        else if (Input.GetKey(KeyCode.LeftArrow))
            _rigidbody.velocity = Vector3.left * _speed;
        else if (Input.GetKey(KeyCode.RightArrow))
            _rigidbody.velocity = Vector3.right * _speed;
        else
            _rigidbody.velocity = Vector3.zero;
    }
}
