using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private void Update()
    {
 //       if (Input.touchCount > 0)
       if (Input.GetMouseButtonDown(0))
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
