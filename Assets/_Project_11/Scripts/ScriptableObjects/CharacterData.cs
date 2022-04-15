using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "ScriptableObjects/CharacterData")]
public class CharacterData : ScriptableObject
{
    [SerializeField] private int id;
    [SerializeField] private string _name;
    [SerializeField] private int health;
    [SerializeField] private float speed;
    [SerializeField] private int damage;

    public int Id => id;
    public string Name => _name;
    public int Health => health;
    public float Speed => speed;
    public int Damage => damage;
}