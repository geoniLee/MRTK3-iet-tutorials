using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject boat;
    [SerializeField] private GameObject coral;
    [SerializeField] private GameObject darkPurpleSeaGrass;
    [SerializeField] private GameObject greenSeaGrass;
    [SerializeField] private GameObject lightPurpleSeaGrass;
    [SerializeField] private GameObject largeRock;
    [SerializeField] private GameObject mediumRock;
    [SerializeField] private GameObject smallRock;
    [SerializeField] private GameObject treasureChest;
    [SerializeField] private GameObject tubeCoral;
    [SerializeField] Transform parent;

    public void SpawnBoat()
    {
        Vector3 position = new Vector3(-.2f, 1.6f, .7f);
        Instantiate(boat, position, Quaternion.Euler(0, 180,0), parent);
    }
    public void SpawnCoral()
    {
        Vector3 position = new Vector3(.19f, 1.6f, .7f);
        Instantiate(coral, position, Quaternion.Euler(0, 180, 0), parent);
    }

    public void SpawnDarkPurpleSeaGrass()
    {
        Vector3 position = new Vector3(-.24f, 1.6f, .7f);
        Instantiate(darkPurpleSeaGrass, position, Quaternion.Euler(0, 180, 0), parent);
    }

    public void SpawnGreenSeaGrass()
    {
        Vector3 position = new Vector3(0.15f, 1.6f, .7f);
        Instantiate(greenSeaGrass, position, Quaternion.Euler(0, 180, 0), parent);
    }

    public void SpawnLightPurpleSeaGrass()
    {
        Vector3 position = new Vector3(.19f, 1.6f, .7f);
        Instantiate(lightPurpleSeaGrass, position, Quaternion.Euler(0, 180, 0), parent);
    }

    public void SpawnLargeRock()
    {
        Vector3 position = new Vector3(.23f, 1.6f, .7f);
        Instantiate(largeRock, position, Quaternion.Euler(0, 180, 0), parent);
    }

    public void SpawnMediumRock()
    {
        Vector3 position = new Vector3(.26f, 1.6f, .85f);
        Instantiate(mediumRock, position, Quaternion.Euler(0, 180, 0), parent);
    }

    public void SpawnSmallRock()
    {
        Vector3 position = new Vector3(.23f, 1.6f, .85f);
        Instantiate(smallRock, position, Quaternion.Euler(0, 180, 0), parent);
    }

    public void SpawnTreasureChest()
    {
        Vector3 position = new Vector3(0, 1.6f, .78f);
        Instantiate(treasureChest, position, Quaternion.Euler(0, 180, 0), parent);
    }

    public void SpawnTubeCoral()
    {
        Vector3 position = new Vector3(.14f, 1.6f, .7f);
        Instantiate(tubeCoral, position, Quaternion.Euler(0, 180, 0), parent);
    }

    public void ClearSpawnObjects(string objectName){
        // 모든 자식 오브젝트를 순회하며 이름에 objectName이 포함된 오브젝트를 찾아 제거합니다.        
        foreach(Transform child in parent){
            if(child.gameObject.name==objectName){
                Destroy(child.gameObject);
            }
        }
    }
}
