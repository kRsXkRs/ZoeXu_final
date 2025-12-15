using UnityEngine;
using UnityEngine.UI;

public class DoorCGController_UI : MonoBehaviour
{
    [Header("Door CG")]
    public Image doorCgImage;
    public Sprite door0;
    public Sprite door1;
    public Sprite door2;

    [Header("Background")]
    public Image bgImage;      // ±³¾°µÄImage
    public Sprite bgDoor;      // ÃÅ¿Ú½×¶Î±³¾°
    public Sprite bgRoom;      // ¿ÍÌü/·¿¼ä½×¶Î±³¾°

    // ===== Door CG =====
    public void DoorShow()
    {
        if (doorCgImage != null)
            doorCgImage.gameObject.SetActive(true);
    }

    public void DoorHide()
    {
        if (doorCgImage != null)
            doorCgImage.gameObject.SetActive(false);
    }

    public void Door0() { SetDoor(door0); }
    public void Door1() { SetDoor(door1); }
    public void Door2() { SetDoor(door2); }

    void SetDoor(Sprite s)
    {
        if (doorCgImage == null) return;
        if (s == null) return;
        doorCgImage.sprite = s;
    }

    // ===== Background =====
    public void BGDoor() { SetBG(bgDoor); }
    public void BGRoom() { SetBG(bgRoom); }

    void SetBG(Sprite s)
    {
        if (bgImage == null) return;
        if (s == null) return;
        bgImage.sprite = s;
        bgImage.gameObject.SetActive(true);
    }
}
