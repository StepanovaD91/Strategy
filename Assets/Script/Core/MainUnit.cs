using UnityEngine;
public class MainUnit : MonoBehaviour, ISelecatable
{
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;

    public bool Interact => throw new System.NotImplementedException(); //пришлось добавить, была ошибка


    [SerializeField] private float _maxHealth = 100;
    [SerializeField] private Sprite _icon;
    
    private float _health = 100;
}
