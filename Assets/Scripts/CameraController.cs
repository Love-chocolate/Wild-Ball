using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _horizontalSpeed = 2.0f;
    [SerializeField] private float _verticalSpeed = 2.0f;
    [SerializeField] private float _initialDistance = 6.0f;
    [SerializeField] private float _minVerticalAngle = -30.0f;
    [SerializeField] private float _maxVerticalAngle = 30.0f;
    [SerializeField] private float _rayLength = 10.0f;

    private float heightOffset = 0.7f;
    private float rotationX = 0;
    private float rotationY = 0;
    private float distance;

    void Start()
    {
        distance = _initialDistance;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if( _player != null && Cursor.visible == false)
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            rotationX -= mouseY * _verticalSpeed;
            rotationY += mouseX * _horizontalSpeed;

            rotationX = Mathf.Clamp(rotationX, _minVerticalAngle, _maxVerticalAngle);

            Ray ray = new Ray(_player.position, -transform.forward);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, _rayLength))
            {
                distance = hit.distance - heightOffset;
            }
            else
            {
                distance = _initialDistance - 0.7f;
            }

            Quaternion rotation = Quaternion.Euler(rotationX, rotationY, 0);
            Vector3 offset = rotation * new Vector3(0, 0, -distance);
            transform.position = _player.position + offset;
            transform.rotation = rotation;
        }
    }
}