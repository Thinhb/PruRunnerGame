using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDecor : MonoBehaviour
{
    public enum MoveDirections
    {
        LEFT, RIGHT
    }

    [Header("Settings")]
    [SerializeField] public float moveSpeed = 6f;
    [SerializeField] private float minDistanceToPoint = 0.1f;

    public float MoveSpeed => moveSpeed;

    public MoveDirections Direction { get; set; }

    public List<Transform> points = new List<Transform>();

    private bool _playing;
    private bool _moved;
    private int _currentPoint = 0;
    private Vector3 _currentPosition;
    private Vector3 _previousPosition;

    private void Start()
    {

        _playing = true;

        _previousPosition = new Vector2(0f, 0f);
        _currentPosition = new Vector2(0f, 0f);
        transform.position = points[0].position;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        // Set first position
        if (!_moved)
        {
            transform.position = _currentPosition + points[0].position;
            _currentPoint++;
            _moved = true;
        }
        if (_currentPoint % 2 == 0)
        {
            transform.localScale = new Vector2(130, 130);
        }
        else
        {
            transform.localScale = new Vector2(-130, 130);
        }
        // Move to next point
        transform.position = Vector3.MoveTowards(transform.position, _currentPosition + points[_currentPoint].position, Time.deltaTime * moveSpeed);

        // Evaluate move to next point
        float distanceToNextPoint = Vector3.Distance(_currentPosition + points[_currentPoint].position, transform.position);
        if (distanceToNextPoint < minDistanceToPoint)
        {
            _previousPosition = transform.position;
            _currentPoint++;
        }

        // Define move direction
        if (_previousPosition != Vector3.zero)
        {
            if (transform.position.x > _previousPosition.x)
            {
                Direction = MoveDirections.RIGHT;
                //transform.localScale = new Vector2(1, 1);
            }
            else if (transform.position.x < _previousPosition.x)
            {
                Direction = MoveDirections.LEFT;
                //transform.localScale = new Vector2(-1, 1);
            }
        }

        // If we are on the last point, reset our position to the first one
        if (_currentPoint == points.Count)
        {
            _currentPoint = 0;
        }
    }

    private void OnDrawGizmos()
    {
        if (transform.hasChanged && !_playing)
        {
            _currentPosition = transform.position;
        }

        if (points != null)
        {
            for (int i = 0; i < points.Count; i++)
            {
                if (i < points.Count)
                {
                    // Draw points
                    Gizmos.color = Color.red;
                    Gizmos.DrawWireSphere(points[i].position, 0.4f);

                    // Draw lines
                    Gizmos.color = Color.black;
                    if (i < points.Count - 1)
                    {
                        Gizmos.DrawLine(points[i].position, points[i + 1].position);
                    }

                    // Draw line from last point to first point
                    if (i == points.Count - 1)
                    {
                        Gizmos.DrawLine(points[i].position, points[0].position);
                    }
                }
            }
        }
    }
}
