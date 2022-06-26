using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationManager : MonoBehaviour
{
    public Animator anim;
    public Button btn1, btn2, btn5, btn6;

    // Start is called before the first frame update
    void Start()
    {
        
        anim = GetComponent<Animator>();
        Debug.Log("통역 시작");
        
        btn1 = GetComponent<Button>();
        //btn1.onClick.AddListener(vo_1);

        //btn1 = transform.Find("vo_1").GetComponent<Button>();
        /*
        btn1.onClick.AddListener(OnButton1Clicked);
        btn2.onClick.AddListener(OnButton2Clicked);
        btn5.onClick.AddListener(OnButton5Clicked);
        btn6.onClick.AddListener(OnButton6Clicked);*/
    }   

    /*
    public void OnButton1Clicked()
    {
        anim.SetInteger("idle", 1);
        anim.SetBool("new bool",false);
        Debug.Log("click");
    }
    public void OnButton2Clicked()
    {
        anim.SetInteger("idle", 2);
    }
    public void OnButton5Clicked()
    {
        anim.SetInteger("idle", 5);
    }
    public void OnButton6Clicked()
    {
        anim.SetInteger("idle", 6);
    }*/

    /*
     public void vo_1()
     {
        anim.SetInteger("basic_idle", 1);
        //anim.SetBool("vo_1", false);
        Debug.Log("버튼 눌림");
     }
     public void vo_2()
     {
         anim.SetInteger("idle", 2);
     }
     public void vo_5()
     {
         anim.SetInteger("New Int", 5);
     }
     public void vo_6()
     {
         anim.SetInteger("New Int", 6);
     }*/

    public void ChangeAnim()
    {
        if (btn1 == Input.GetMouseButtonDown(0))
        {
            anim.SetInteger("basic_idle", 1);
            //anim.SetBool("vo_1", false);
            Debug.Log("1 버튼 a눌림");
        }

        if (btn2 == Input.GetMouseButtonDown(0))
        {
            anim.SetInteger("basic_idle", 2);
            //anim.SetBool("vo_1", false);
            Debug.Log("1 버튼 a눌림");
        }

        else
        {

        }


    }

}
