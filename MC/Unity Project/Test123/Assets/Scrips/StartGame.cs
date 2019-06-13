using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private void Update()
    {
        //if (Application.platform == RuntimePlatform.Android)
        //{
        //    Vector3 tpos = Input.GetTouch(0).position;

        //    if (tpos.x <= Screen.width / 2)
        //    {
        //        SceneManager.LoadScene("StageScene");
        //    }
        //}
 //      if (Input.touchCount > 0)
       if (Input.GetMouseButtonDown(0))
            SceneManager.LoadScene("StageScene");
    }
    public void onClick()
    {
        SceneManager.LoadScene("GameScene");
    }
    /*public void ChangeGameScene()
    {
        SceneManager.LoadScene("OptionScene");
    }*/
 /*   public void OnPointerClick(PointerEventData eventData)
    {
        
    }*/
}
