using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPanel : Panel
{
    public void ContinueButton()
    {
        GameManager.instance.level.StartGame();
    }
}
