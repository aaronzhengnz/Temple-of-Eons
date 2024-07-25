using System.Collections;
using UnityEngine;
using TMPro;

public class TextFader : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public float fadeDuration = 1f; // Duration of one fade cycle (in and out)

    private void Start()
    {
        if (textMeshPro == null)
        {
            textMeshPro = GetComponent<TextMeshProUGUI>();
        }
        StartCoroutine(FadeText());
    }

    private IEnumerator FadeText()
    {
        Color originalColor = textMeshPro.color;
        while (true)
        {
            // Fade in
            yield return StartCoroutine(FadeToAlpha(1f, fadeDuration / 2));
            // Fade out
            yield return StartCoroutine(FadeToAlpha(0f, fadeDuration / 2));
        }
    }

    private IEnumerator FadeToAlpha(float targetAlpha, float duration)
    {
        Color currentColor = textMeshPro.color;
        float startAlpha = currentColor.a;
        float timer = 0f;

        while (timer < duration)
        {
            timer += Time.deltaTime;
            float alpha = Mathf.Lerp(startAlpha, targetAlpha, timer / duration);
            textMeshPro.color = new Color(currentColor.r, currentColor.g, currentColor.b, alpha);
            yield return null;
        }

        textMeshPro.color = new Color(currentColor.r, currentColor.g, currentColor.b, targetAlpha);
    }
}
