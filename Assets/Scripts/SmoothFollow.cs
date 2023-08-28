using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    [SerializeField] private Transform _target; // Второй объект, за которым нужно двигаться
    [SerializeField] private float _smoothSpeed = 5f; // Скорость плавного движения

    private void Update()
    {
        // Проверяем, что есть цель для следования
        if (_target != null)
        {
            // Вычисляем новую позицию текущего объекта, плавно двигая его к цели
            Vector3 newPosition = Vector3.Lerp(transform.position, _target.position, _smoothSpeed * Time.deltaTime);

            // Применяем новую позицию
            transform.position = newPosition;
        }
    }
}