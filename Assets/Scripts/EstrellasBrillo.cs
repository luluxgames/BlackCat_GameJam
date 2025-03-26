using UnityEngine;
using UnityEngine.UI;
using DG.Tweening; // Importa DOTween

public class BrilloEstrellas : MonoBehaviour
{
    Image image; // Referencia a la imagen

    void Start()
    {
        image = GetComponent<Image>();

        if (image == null)
        {
            Debug.LogError("No encontré el componente Image. Asegúrate de que este script está en una UI Image.");
            return;
        }

        // Tween para hacer que el alpha vaya de 0 (invisible) a 1 (completo) en loop
        image.DOFade(1f, 2f) // Sube el alpha a 1 en 2 segundos
            .SetEase(Ease.InOutSine) //  Suavidad total
            .SetLoops(-1, LoopType.Yoyo); // Hace que desaparezca y reaparezca infinitamente
    }
}