using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blink : Counter
{
    public Button btn;
    public Image img;
    public Text txt;

    Vector3 size = new Vector3();
    Vector3 imgsize = new Vector3();
    Vector3 txtsize = new Vector3();

    private void Start()
    {
        if (btn != null)
            size = btn.transform.localScale;
        if (img != null)
            imgsize = img.transform.localScale;
        if (txt != null)
            txtsize = txt.transform.localScale;
    }

    public void OnPointerDown()
    {
        if (btn != null)
            btn.transform.localScale = new Vector3(size.x + 0.1f, size.y + 0.1f, 1);
        if (img != null)
            img.transform.localScale = new Vector3(imgsize.x + 0.1f, imgsize.y + 0.1f, 1);
        if (txt != null)
            txt.transform.localScale = new Vector3(txtsize.x + 0.1f, txtsize.y + 0.1f, 1);
    }

    public void OnPointerUp()
    {
        if (btn != null)
            btn.transform.localScale = new Vector3(size.x, size.y, 1);
        if (img != null)
            img.transform.localScale = new Vector3(imgsize.x, imgsize.y, 1);
        if (txt != null)
            txt.transform.localScale = new Vector3(txtsize.x, txtsize.y, 1);
    }
}
