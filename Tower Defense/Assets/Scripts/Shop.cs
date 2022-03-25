using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret ()
    {
        Debug.Log("Standard turret selected");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }

    public void PurchaseMissileLuncher()
    {
        Debug.Log("Missile Launcher selected");
        buildManager.SetTurretToBuild(buildManager.missileLauncherPrefab);
    }

}
