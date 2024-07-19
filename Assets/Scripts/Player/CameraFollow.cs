using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target; // Tham chiếu đến nhân vật mà camera sẽ theo dõi
    [SerializeField] private float smoothing = 0.125f; // Độ mượt khi camera di chuyển
    [SerializeField] private Vector3 offset; // Khoảng cách giữa camera và nhân vật

    private void FixedUpdate()
    {
        if (target == null)
            return;

        Vector3 desiredPosition = target.position + offset; // Vị trí mong muốn của camera
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothing); // Tính toán vị trí mượt mà
        transform.position = smoothedPosition; // Cập nhật vị trí của camera
    }
}
