using UnityEngine;

public class RectFix : MonoBehaviour
{
    void OnEnable()
    {
        var rt = GetComponent<RectTransform>();
        if (!rt) return;
        rt.anchorMin = rt.anchorMax = new Vector2(0.5f, 0.5f);
        rt.pivot = new Vector2(0.5f, 0.5f);
        rt.anchoredPosition = Vector2.zero;
    }
}
