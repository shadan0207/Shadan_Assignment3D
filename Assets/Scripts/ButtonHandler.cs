using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public GameObject uiPanel, uiBuilding_Panel, uiRoad_Panel, uiTrees_Panel, uiVehicle_Panel, uiProps_Panel;
    private bool uiPanelActive = false;
    private bool uiBuildingPanelActive = false;
    private bool uiRoadPanelActive = false;
    private bool uiTreePanelActive = false;
    private bool uiVehiclesPanelActive = false;
    private bool uiPropsPanelActive = false;

    public void OnRedButtonClick()
    {
        TogglePanel(uiPanel, ref uiPanelActive);
    }

    public void OnBuildingButtonClick()
    {
        TogglePanel(uiBuilding_Panel, ref uiBuildingPanelActive);
        
        DeactivateOtherPanels(uiBuilding_Panel);
    }

    public void OnRoadButtonClick()
    {
        TogglePanel(uiRoad_Panel, ref uiRoadPanelActive);
        
        DeactivateOtherPanels(uiRoad_Panel);
    }

    public void OnTreeButtonClick()
    {
        TogglePanel(uiTrees_Panel, ref uiTreePanelActive);
       
        DeactivateOtherPanels(uiTrees_Panel);
    }

    public void OnVehicleButtonClick()
    {
        TogglePanel(uiVehicle_Panel, ref uiVehiclesPanelActive);
        
        DeactivateOtherPanels(uiVehicle_Panel);
    }

    public void OnPropsButtonClick()
    {
        TogglePanel(uiProps_Panel, ref uiPropsPanelActive);
        
        DeactivateOtherPanels(uiProps_Panel);
    }

    private void TogglePanel(GameObject panel, ref bool panelActive)
    {
        panel.SetActive(!panelActive);
        panelActive = !panelActive;
    }

    private void DeactivateOtherPanels(GameObject currentPanel)
    {
       
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

