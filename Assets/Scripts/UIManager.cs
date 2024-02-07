using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public GameObject inOutUI;
    public GameObject inUI;
    public GameObject outUI;
    public GameObject noMoneyUI;
    public GameObject falseInput;

    private void Awake()
    {
        Instance = this;

        inOutUI.SetActive(true);
        inUI.SetActive(false);
        outUI.SetActive(false);
    }

    public void InCashOpen()
    {
        inUI.SetActive(true);
        inOutUI.SetActive(false);
    }
    public void OutCashOpen()
    {
        outUI.SetActive(true);
        inOutUI.SetActive(false);
    }
    public void InOutUIOpen()
    {
        inUI.SetActive(false);
        outUI.SetActive(false);
        inOutUI.SetActive(true);
    }

    public void NoMoneyUIOpen()
    {
        noMoneyUI.SetActive(true);
    }
    public void NoMoneyUIClose()
    {
        noMoneyUI.SetActive(false);
    }

    public void FalseInputUIOpen()
    {
        falseInput.SetActive(true);
    }
    public void FalseInputUIClose()
    {
        falseInput.SetActive(false);
    }
}
