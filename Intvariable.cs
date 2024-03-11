using UnityEngine;

public class IntVariable : MonoBehaviour
{
{
    private int value;

    public IntVariable(int value)
    {
        this.value = value;
    }

    public int GetValue()
    {
        return this.value;
    }

    public void SetValue(int value)
    {
        this.value = value;
    }
}