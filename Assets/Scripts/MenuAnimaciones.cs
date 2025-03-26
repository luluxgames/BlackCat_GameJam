using UnityEngine;
using DG.Tweening; // Importa DOTween

public class MoverImagen : MonoBehaviour
{
    RectTransform imageRect;

    void Start()
    {
        imageRect = GetComponent<RectTransform>();

        if (imageRect == null)
        {
            Debug.LogError(" No encontré el RectTransform. ¿Está este script en la imagen UI?");
            return;
        }

        // Mover la imagen con un rebote al llegar
        imageRect.DOAnchorPos(new Vector2(0, 242.21f), 2f)
            .SetEase(Ease.OutBounce); // Rebote suave al final
    }
}