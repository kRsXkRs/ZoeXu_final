using UnityEngine;
using UnityEngine.UI;

public class SimpleCGController : MonoBehaviour
{
    [Header("显示CG的Image")]
    public Image cgImage;

    [Header("要切换的CG贴图（按顺序放）")]
    public Sprite[] cgSprites = new Sprite[6];
    // 想用几张就拖几张，4~6 都行

    void Awake()
    {
        // 默认先关掉
        HideCG();
    }

    // 关掉整块 CG
    public void HideCG()
    {
        if (cgImage != null)
        {
            cgImage.gameObject.SetActive(false);
        }
    }

    // 打开 CG（不会切图，只是显示当前这张）
    public void ShowCG()
    {
        if (cgImage != null)
        {
            cgImage.gameObject.SetActive(true);
        }
    }

    // ===== 无参接口，给 Fungus 调用 =====
    public void CG0() => SetCG(0);
    public void CG1() => SetCG(1);
    public void CG2() => SetCG(2);
    public void CG3() => SetCG(3);
    public void CG4() => SetCG(4);
    public void CG5() => SetCG(5);

    // 真正切贴图的内部函数
    void SetCG(int index)
    {
        if (cgImage == null) return;
        if (cgSprites == null) return;
        if (index < 0 || index >= cgSprites.Length) return;
        if (cgSprites[index] == null) return;

        cgImage.sprite = cgSprites[index];
        cgImage.gameObject.SetActive(true);
    }
}
