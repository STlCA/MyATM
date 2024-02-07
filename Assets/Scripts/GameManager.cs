using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public string myName;
    public int cash;
    public int banlance;

    [SerializeField] private Text curName;
    [SerializeField] private Text curCash;
    [SerializeField] private Text curBanlance;

    [SerializeField] private InputField addCashSelf;
    [SerializeField] private InputField addBanlanceSelf;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        curName.text = myName;
        curCash.text = cash.ToString("N0");
        curBanlance.text = banlance.ToString("N0");
    }

    public void AddCash1()
    {
        if (banlance - 10000 < 0)
        {
            UIManager.Instance.NoMoneyUIOpen();
            return;
        }
        cash += 10000;
        banlance -= 10000;
    }
    public void AddCash2()
    {
        if (banlance - 30000 < 0)
        {
            UIManager.Instance.NoMoneyUIOpen();
            return;
        }
        cash += 30000;
        banlance -= 30000;
    }
    public void AddCash3()
    {
        if (banlance - 50000 < 0)
        {
            UIManager.Instance.NoMoneyUIOpen();
            return;
        }
        cash += 50000;
        banlance -= 50000;
    }
    public void AddCashSelf()
    {
        bool parseSuccess = int.TryParse(addCashSelf.text, out var temp);
        if (!parseSuccess)
        { 
            UIManager.Instance.FalseInputUIOpen();
            return;
        }

        if (banlance - int.Parse(addCashSelf.text) < 0)
        {
            UIManager.Instance.NoMoneyUIOpen();
            return;
        }
        cash += int.Parse(addCashSelf.text);
        banlance -= int.Parse(addCashSelf.text);

        addCashSelf.text = "";
    }

    public void AddBanlance1()
    {
        if (cash - 10000 < 0)
        {
            UIManager.Instance.NoMoneyUIOpen();
            return;
        }
        banlance += 10000;
        cash -= 10000;
    }
    public void AddBanlance2()
    {
        if (cash - 30000 < 0)
        {
            UIManager.Instance.NoMoneyUIOpen();
            return;
        }
        banlance += 30000;
        cash -= 30000;
    }
    public void AddBanlance3()
    {
        if (cash - 50000 < 0)
        {
            UIManager.Instance.NoMoneyUIOpen();
            return;
        }
        banlance += 50000;
        cash -= 50000;
    }
    public void AddBanlanceSelf()
    {
        bool parseSuccess = int.TryParse(addBanlanceSelf.text, out var temp);
        if (!parseSuccess)
        {
            UIManager.Instance.FalseInputUIOpen();
            return;
        }
        if (cash - int.Parse(addBanlanceSelf.text) < 0)
        {
            UIManager.Instance.NoMoneyUIOpen();
            return;
        }
        banlance += int.Parse(addBanlanceSelf.text);
        cash -= int.Parse(addBanlanceSelf.text);

        addBanlanceSelf.text = "";
    }
}
