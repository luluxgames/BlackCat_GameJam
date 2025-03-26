using UnityEngine;
using UnityEngine.UI; // Para acceder a los botones
using UnityEngine.EventSystems; // Para manejar eventos de clic y hover

public class BotonSonido : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    public AudioClip sonidoClick; // Sonido cuando se hace clic
    public AudioClip sonidoHover; // Sonido cuando el cursor pasa sobre el bot�n
    private AudioSource audioSource; // Componente de AudioSource para reproducir los sonidos

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Obtener el AudioSource del bot�n

        if (audioSource == null)
        {
            Debug.LogError("El AudioSource no est� presente en el bot�n. A��delo para reproducir el sonido.");
        }
    }

    // M�todo que se llama cuando se hace clic en el bot�n
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

    // M�todo que se llama cuando el cursor pasa sobre el bot�n
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