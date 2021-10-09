using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerPanels : MonoBehaviour
{

    [SerializeField] private GameObject buildPanel;
    [SerializeField] private GameObject upgradePanel;
    [SerializeField] private GameObject gamePanel;
    
    public int targetHouseVar = 0;
    private CellParam targetCellParam;


        private void Start()
    {
        buildPanel.SetActive(false);
        upgradePanel.SetActive(false);
       
        OnClick.onCellClicked += CellClickedHandler;
        
    }

    private void OnDisable()
    {
        OnClick.onCellClicked -= CellClickedHandler;
    }
    

    public void SetHouseLevel()
    {
        if(targetCellParam.houseLevel<3) targetCellParam.houseLevel++;
        upgradePanel.SetActive(false);
    }
    
    
    
    public void SetTargetHouseVar(int variant)
    {
        targetHouseVar = variant;
    }

    
    public void Build()
    {
        if (targetHouseVar == 0)
        {
            return;
        }

        targetCellParam.houseVar = targetHouseVar;
        buildPanel.SetActive(false);
        targetCellParam.houseLevel = 1;
        targetHouseVar = 0;

    }

    

    private void CellClickedHandler(CellParam cellParam)
    {
        targetCellParam = cellParam;
        
        if (targetCellParam.houseVar == 0)
        {
            buildPanel.SetActive(true);
        }
        else if (targetCellParam.houseLevel>=3f)
        {
            return;
        }
        else
        { 
            upgradePanel.SetActive(true);
        }
            
        
        
    }
}
