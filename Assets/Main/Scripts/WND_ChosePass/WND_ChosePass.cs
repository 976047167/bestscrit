﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WND_ChosePass : MonoBehaviour
{
    private string printString;
    private UILabel labTips;
    private GameObject btnShowAll;
    private int preserntIndex;
    private bool isPrinting;
    GameObject self;
    // Use this for initialization
    void Awake()
    {
        instance = this;
        labTips = transform.Find("imgBg/imgTips/labTips").GetComponent<UILabel>();
        btnShowAll = transform.Find("btnShowAll").gameObject;
        UIEventListener.Get(btnShowAll.gameObject).onClick = PrintStringAll;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    static WND_ChosePass instance = null;
    public static void ShowDialog(int index)
    {
        if (instance == null)
        {
            GameObject prefab = (GameObject)Resources.Load("Prefabs/UIForm/WND");
            GameObject wnd = Instantiate(prefab) as GameObject;
            wnd.transform.position = Vector3.zero;
        }

        instance.showDialog(index);

    }
    private void OnDestroy()
    {
        instance = null;
    }
    private void showDialog(int index)
    {
        preserntIndex = index;
        StopCoroutine("PrintStringByStep");
        printString = DataDialog.getInstance().getDialogString(index);
        StartCoroutine("PrintStringByStep");
    }

    private IEnumerator PrintStringByStep()
    {
        string printString = string.Copy(this.printString);
        if (printString.Length == 0)
        {
            print("pintStringByStep has no String to print!");
            yield break;
        }

        btnShowAll.SetActive(true);
        isPrinting = true;
        print("pintStringByStep is printing" + printString);
        for (int i = 0; i < printString.Length; i++)
        {
            labTips.text = printString.Substring(0, i);
            yield return new WaitForSeconds(0.5f);
        }
        isPrinting = false;
    }
    private void PrintStringAll(GameObject btn)
    {
        if (isPrinting)
        {
            StopCoroutine("PrintStringByStep");
            print("PrintStringByStep is stop");
            labTips.text = this.printString;
        }
        else
        {
            int type = DataDialog.getInstance().getDialogType(preserntIndex);
            switch (type)
            {
                case 1:
                    List<int> nextIndices = DataDialog.getInstance().getDialogNextIndices(preserntIndex);
                    int nextIndex = nextIndices[0];
                    if (nextIndex == 0)
                    {
                        btnShowAll.SetActive(false);
                        return;
                    }
                    showDialog(nextIndex);
                    break;
                default:
                    print("Unknow type!");
                    break;
            }

        }
     

    }
}
