using UnityEngine;
public class ProduceUnitCommand : IProduceUnitCommand
{
    public GameObject UnitPrefab => _unitPrefab;
    [InjectAsset("ChomperUnit")] private GameObject _unitPrefab;
}