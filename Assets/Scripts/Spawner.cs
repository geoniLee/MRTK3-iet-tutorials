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
    private Dictionary<string, GameObject> prefabMap;
    public List<GameObject> clonePrefabs = new List<GameObject>();

    // 프리팹을 사전 형태로 초기화합니다.
    private void Awake() {
        prefabMap = new Dictionary<string, GameObject>
        {
            { "Boat", boat },
            { "Coral", coral },
            { "Dark Purple Sea Grass", darkPurpleSeaGrass },
            { "Green Sea Grass", greenSeaGrass },
            { "Light Purple Sea Grass", lightPurpleSeaGrass },
            { "Rock-Large", largeRock },
            { "Rock-Medium", mediumRock },
            { "Rock-Small", smallRock },
            { "Treasure Chest", treasureChest },
            { "Tube Coral", tubeCoral }
        };
    }

    // prefabName에 해당하는 프리팹을 생성하고, 지정된 위치에 배치합니다.
    public void SpawnPrefab(string prefabName)
    {
        Vector3 position = new Vector3(0, 1.6f, .7f); // 기본 위치
        GameObject prefab = prefabMap[prefabName];
        GameObject clone = Instantiate(prefab, position, Quaternion.Euler(0, 180, 0), parent);
        clonePrefabs.Add(clone);
    }

    // clonePrefabs 리스트에서 이름에 objectName이 포함된 오브젝트를 찾아 제거합니다.
    public void destroySpawnedobject(string objectName){
        for (int i = clonePrefabs.Count - 1; i >= 0; i--)
        {
            if (clonePrefabs[i].name.StartsWith(objectName + "(Clone)"))
            {
                Destroy(clonePrefabs[i]);
                clonePrefabs.RemoveAt(i);
            }
        }
    }
}
