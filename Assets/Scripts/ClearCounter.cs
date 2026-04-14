using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    [SerializeField] private Transform counterTopPoint;

    public void Interact() {
        Debug.Log("Interact!");
        Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
        kitchenObjectTransform.localPosition = Vector3.zero;

        KitchenObjectSO spawnedSO = kitchenObjectTransform.GetComponent<KitchenObject>().GetKitchenObjectSO();
        Debug.Log("Spawned: " + spawnedSO.objectName);
    }
}
