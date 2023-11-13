/*using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public GameObject uiPanel, uiBuilding_Panel, uiRoad_Panel, uiTrees_Panel, uiVehicle_Panel; 
    public bool uiPanelActive = false;
    public bool uiBuildingPanelActive= false;
    public bool uiRoadPanelActive= false;
    public bool uiTreePanelActive= false;
    public bool uiVehiclesPanelActive= false;

    private void Start()
    {
        // Assuming the panel is initially hidden
        //uiPanel.SetActive(uiPanelActive);
    }

    public void OnRedButtonClick()
    {
        uiPanel.SetActive(!uiPanelActive);
        uiPanelActive = !uiPanelActive;
    }

    public void OnBuildingButtonClick()
    {
        uiBuilding_Panel.SetActive(!uiBuildingPanelActive);
        uiBuildingPanelActive = !uiBuildingPanelActive; 
    }
    public void OnRoadButtonClick()
    {    
        
         uiRoad_Panel.SetActive(!uiRoadPanelActive);
         uiRoadPanelActive = !uiRoadPanelActive;
        
    }

    public void OnTreeButtonClick()
    {
        uiTrees_Panel.SetActive(!uiTreePanelActive);
        uiTreePanelActive = !uiTreePanelActive;
    }

    public void OnVehicleButtonClick()
    {
        uiVehicle_Panel.SetActive(!uiVehiclesPanelActive);
        uiVehiclesPanelActive = !uiVehiclesPanelActive;
    }
}*/


using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public GameObject uiPanel, uiBuilding_Panel, uiRoad_Panel, uiTrees_Panel, uiVehicle_Panel, uiProps_Panel;
    public bool uiPanelActive = false;
    public bool uiBuildingPanelActive = false;
    public bool uiRoadPanelActive = false;
    public bool uiTreePanelActive = false;
    public bool uiVehiclesPanelActive = false;
    public bool uiPropsPanelActive = false;

    public void OnRedButtonClick()
    {
        TogglePanel(uiPanel, ref uiPanelActive);
    }

    public void OnBuildingButtonClick()
    {
        TogglePanel(uiBuilding_Panel, ref uiBuildingPanelActive);
        // Deactivate other panels
        DeactivateOtherPanels(uiBuilding_Panel);
    }

    public void OnRoadButtonClick()
    {
        TogglePanel(uiRoad_Panel, ref uiRoadPanelActive);
        // Deactivate other panels
        DeactivateOtherPanels(uiRoad_Panel);
    }

    public void OnTreeButtonClick()
    {
        TogglePanel(uiTrees_Panel, ref uiTreePanelActive);
        // Deactivate other panels
        DeactivateOtherPanels(uiTrees_Panel);
    }

    public void OnVehicleButtonClick()
    {
        TogglePanel(uiVehicle_Panel, ref uiVehiclesPanelActive);
        // Deactivate other panels
        DeactivateOtherPanels(uiVehicle_Panel);
    }

    public void OnPropsButtonClick()
    {
        TogglePanel(uiProps_Panel, ref uiPropsPanelActive);
        // Deactivate other panels
        DeactivateOtherPanels(uiProps_Panel);
    }

    private void TogglePanel(GameObject panel, ref bool panelActive)
    {
        panel.SetActive(!panelActive);
        panelActive = !panelActive;
    }

    private void DeactivateOtherPanels(GameObject currentPanel)
    {
        // Deactivate all other panels except the current one
        //if (currentPanel != uiPanel)
        //{
            //uiPanel.SetActive(false);
          //  uiPanelActive = false;
        //}

        if (currentPanel != uiBuilding_Panel)
        {
            uiBuilding_Panel.SetActive(false);
            uiBuildingPanelActive = false;
        }

        if (currentPanel != uiRoad_Panel)
        {
            uiRoad_Panel.SetActive(false);
            uiRoadPanelActive = false;
        }

        if (currentPanel != uiTrees_Panel)
        {
            uiTrees_Panel.SetActive(false);
            uiTreePanelActive = false;
        }

        if (currentPanel != uiVehicle_Panel)
        {
            uiVehicle_Panel.SetActive(false);
            uiVehiclesPanelActive = false;
        }
        if (currentPanel != uiProps_Panel)
        {
            uiProps_Panel.SetActive(false);
            uiPropsPanelActive = false;
        }
    }
}

