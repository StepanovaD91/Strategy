using UnityEngine;
public class MainUnit : MonoBehaviour, ISelecatable, IAttackable
{
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    
    public Sprite Icon => _icon;
    public Transform PivotPoint => _pivotPoint;

    [SerializeField] private Transform _pivotPoint;


    [SerializeField] private float _maxHealth = 100;
    [SerializeField] private Sprite _icon;
    
    private float _health = 100;
}
