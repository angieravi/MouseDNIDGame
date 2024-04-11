using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform tooltipSpawnPoint; // Drag and drop the spawn point Transform in the Inspector

    void Start()
    {
        // Find the tooltip spawn point GameObject by tag
        GameObject spawnPointObject = GameObject.FindGameObjectWithTag("TooltipSpawnPoint");

        // Assign the transform component to the tooltipSpawnPoint variable
        if (spawnPointObject != null)
        {
            tooltipSpawnPoint = spawnPointObject.transform;
        }
        else
        {
            Debug.LogError("Tooltip spawn point not found!");
        }
    }
}
