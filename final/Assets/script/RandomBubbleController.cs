using UnityEngine;
using UnityEngine.UI;

public class NpcSpriteSwitcher : MonoBehaviour
{
    [Header("NPC显示器（固定位置的Image）")]
    public Image npcImage;

    [Header("门口/对话用：NPC的不同图（按顺序放）")]
    public Sprite[] npcSprites; // 7/8/10都行，看你填多少

    [Header("房间用：每个人一张独立立绘")]
    public Sprite roomSprite;

    [Header("气泡显示器（固定位置的Image）")]
    public Image bubbleImage;

    [Header("气泡贴图（固定顺序）")]
    public Sprite[] bubbleSprites = new Sprite[10]; // 你用了Bubble8/Bubble9就至少10格

    void Awake()
    {
        HideBubble();
        // 如果你希望默认NPC也隐藏，打开下一行
        // HideNPC();
    }

    // ===== NPC 显示/隐藏 =====
    public void ShowNPC()
    {
        if (npcImage != null) npcImage.gameObject.SetActive(true);
    }

    public void HideNPC()
    {
        if (npcImage != null) npcImage.gameObject.SetActive(false);
        HideBubble();
    }

    // ===== 门口/对话：切NPC图 =====
    public void NPC0() => SetNpc(0);
    public void NPC1() => SetNpc(1);
    public void NPC2() => SetNpc(2);
    public void NPC3() => SetNpc(3);
    public void NPC4() => SetNpc(4);
    public void NPC5() => SetNpc(5);
    public void NPC6() => SetNpc(6);
    public void NPC7() => SetNpc(7);
    public void NPC8() => SetNpc(8);
    public void NPC9() => SetNpc(9);

    void SetNpc(int i)
    {
        if (npcImage == null) return;
        if (npcSprites == null || i < 0 || i >= npcSprites.Length) return;
        if (npcSprites[i] == null) return;

        npcImage.sprite = npcSprites[i];
        npcImage.gameObject.SetActive(true);
    }

    // ===== 房间：切到房间专用那张 =====
    public void RoomPose()
    {
        if (npcImage == null) return;
        if (roomSprite == null) return;

        npcImage.sprite = roomSprite;
        npcImage.gameObject.SetActive(true);
    }

    // ===== 气泡 =====
    public void HideBubble()
    {
        if (bubbleImage != null) bubbleImage.gameObject.SetActive(false);
    }

    public void Bubble0() => SetBubble(0);
    public void Bubble1() => SetBubble(1);
    public void Bubble2() => SetBubble(2);
    public void Bubble3() => SetBubble(3);
    public void Bubble4() => SetBubble(4);
    public void Bubble5() => SetBubble(5);
    public void Bubble6() => SetBubble(6);
    public void Bubble7() => SetBubble(7);
    public void Bubble8() => SetBubble(8);
    public void Bubble9() => SetBubble(9);

    void SetBubble(int i)
    {
        if (bubbleImage == null) return;
        if (bubbleSprites == null || i < 0 || i >= bubbleSprites.Length) return;
        if (bubbleSprites[i] == null) return;

        bubbleImage.sprite = bubbleSprites[i];
        bubbleImage.gameObject.SetActive(true);
    }
}
