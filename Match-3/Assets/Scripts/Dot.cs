using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{
    private Vector2 _firstTouchPosition;
    private Vector2 _lastTouchPosition;
    public float _swipeAngle = 0;       // TODO make private

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        _firstTouchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnMouseUp()
    {
        _lastTouchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        CalculateAngle();
    }

    private void CalculateAngle()
    {
        _swipeAngle = Mathf.Atan2(_lastTouchPosition.y - _firstTouchPosition.y, _lastTouchPosition.x - _firstTouchPosition.x);
        _swipeAngle = Mathf.Rad2Deg * _swipeAngle;
        Debug.Log(_swipeAngle);
    }
}
