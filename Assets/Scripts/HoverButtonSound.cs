using UnityEngine;
using UnityEngine.UI; // Para acceder a los botones
using UnityEngine.EventSystems; // Para manejar eventos de clic y hover

public class BotonSonido : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    public AudioClip sonidoClick; // Sonido cuando se hace clic
    public AudioClip sonidoHover; // Sonido cuando el cursor pasa sobre el botón
    private AudioSource audioSource; // Componente de AudioSource para reproducir los sonidos

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Obtener el AudioSource del botón

        if (audioSource == null)
        {
            Debug.LogError("El AudioSource no está presente en el botón. Añádelo para reproducir el sonido.");
        }
    }

    // Método que se llama cuando se hace clic en el botón
    public void OnPointerClick(PointerEventData eventData)
    {
        if (sonidoClick != null)
        {
            audioSource.PlayOneShot(sonidoClick); // Reproducir el sonido de clic
        }
        else
        {
            Debug.LogError("No se ha asignado el sonido de clic en el Inspector.");
        }
    }

    // Método que se llama cuando el cursor pasa sobre el botón
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (sonidoHover != null)
        {
            audioSource.PlayOneShot(sonidoHover); // Reproducir el sonido cuando el mouse pasa por encima
        }
        else
        {
            Debug.LogError("No se ha asignado el sonido de hover en el Inspector.");
        }
    }
}