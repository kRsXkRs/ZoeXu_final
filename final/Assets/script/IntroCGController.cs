using UnityEngine;
using UnityEngine.UI;

public class IntroCGController : MonoBehaviour
{
    public GameObject blackOverlay; // BlackOverlay
    public Image cgImage;           // CGImage
    public Sprite[] cgs;            // 11张都拖这里

    private int index = 0;

    public void BlackOn() { if (blackOverlay) blackOverlay.SetActive(true); }
    public void BlackOff() { if (blackOverlay) blackOverlay.SetActive(false); }

    public void ShowCG() { if (cgImage) cgImage.gameObject.SetActive(true); Refresh(); }
    public void HideCG() { if (cgImage) cgImage.gameObject.SetActive(false); }

    public void SetCGTo0() { index = 0; Refresh(); }
    public void NextCG() { index++; if (cgs != null && cgs.Length > 0) index %= cgs.Length; Refresh(); }
    public void PrevCG() { index--; if (cgs != null && cgs.Length > 0) index = (index + cgs.Length) % cgs.Length; Refresh(); }

    public void SetCGToEnd()
    {
        if (cgs == null || cgs.Length == 0) return;
        index = cgs.Length - 1;
        Refresh();
    }

    private void Refresh()
    {
        if (cgImage == null || cgs == null || cgs.Length == 0) return;
        if (index < 0) index = 0;
        if (index >= cgs.Length) index = cgs.Length - 1;
        cgImage.sprite = cgs[index];
    }
}
