using UnityEngine;

public class ClearCounter : BaseCounter {

    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player) {
        if (!HasKitchenObject()) {
            Instantiate(kitchenObjectSO.prefab)
                .GetComponent<KitchenObject>()
                .SetKitchenObjectParent(this);
        } else {
            GetKitchenObject().SetKitchenObjectParent(player);
        }
    }
}
