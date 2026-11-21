using UnityEngine;

public enum TipoIngrediente
{
    Carne,
    Cebolla,
    Tomate,
    Lechuga,
    Queso,
    Condimento,
    PanBase,
    PanTapa

}
public class Ingrediente : MonoBehaviour
{
    public TipoIngrediente tipo;
    [HideInInspector] public bool estaListo = false;
   
}
