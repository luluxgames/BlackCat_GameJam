using UnityEngine;
using DG.Tweening; // Importa DOTween

public class EscalarImagen : MonoBehaviour
{
    RectTransform imageRect;

    void Start()
    {
        imageRect = GetComponent<RectTransform>();

        if (imageRect == null)
        {
            Debug.LogError("No encontré el RectTransform. ¿Está este script en la imagen UI?");
            return;
        }

        // Hacer crecer la imagen de forma suave con retraso de 1s
        imageRect.DOScale(new Vector3(4.9f, 5.39f, 0.8032787f), 2f) // Tamaño más grande en 2 segundos
            .SetEase(Ease.InOutSine) // Suavidad total
            .SetDelay(1f); // Espera 1 segundo antes de empezar
    }
}