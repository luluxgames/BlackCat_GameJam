using UnityEngine;
using UnityEngine.SceneManagement; // Para cargar escenas
using UnityEngine.UI; // Para manejar UI (como el panel de fade)
using System.Collections;

public class BotonCambioEscena : MonoBehaviour
{
    public AudioSource menuMusicx; // AudioSource de la m�sica
    public Image fadePanel; // Referencia al panel negro
    public float fadeDuration = 1f; // Duraci�n del fade (misma para m�sica y panel)
    public string escenaADesCargar = "StoryIntro"; // Nombre de la escena a cargar

    // M�todo p�blico para hacer el fade out y cambiar de escena
    public void OnClickBoton()
    {
        StartCoroutine(FadeInPanelAndFadeOutMusic());
    }

    // Coroutine para el fade in del panel y fade out de la m�sica, luego cambiar de escena
    IEnumerator FadeInPanelAndFadeOutMusic()
    {
        float startVolume = menuMusicx.volume;
        float fadeAmount = 0f;

        // Hacer fade in del panel negro (de transparente a opaco)
        fadePanel.gameObject.SetActive(true); // Aseg�rate de que el panel est� visible
        while (fadeAmount < 1f)
        {
            fadeAmount += Time.deltaTime / fadeDuration; // Aumenta el fadeAmount
            fadePanel.color = new Color(0f, 0f, 0f, Mathf.Clamp01(fadeAmount)); // Actualiza el color del panel
            menuMusicx.volume = Mathf.Lerp(startVolume, 0f, fadeAmount); // Fade out de la m�sica
            yield return null;
        }

        menuMusicx.Stop(); // Detener la m�sica una vez que se haya desvanecido

        // Cambiar de escena despu�s del fade out
        SceneManager.LoadScene(escenaADesCargar);
    }
}
