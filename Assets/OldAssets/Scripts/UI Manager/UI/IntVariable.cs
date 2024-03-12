using UnityEngine;

[CreateAssetMenu(fileName = "New IntVariable", menuName = "Variables/IntVariable")]
public class IntVariable : ScriptableObject
{
    public int Value;
    public delegate void OnChange(int newValue);
    public event OnChange OnValueChange;

    public void SetValue(int newValue)
    {
        Value = newValue;
        OnValueChange?.Invoke(Value);
    }
}