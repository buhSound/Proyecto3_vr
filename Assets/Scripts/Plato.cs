using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using Oculus.Interaction;
using Oculus.Interaction.HandGrab;

public class Plato : MonoBehaviour
{
    [Header("Pedido a validar")]
    public List<TipoIngrediente> pedidoActual = new List<TipoIngrediente>()
    {
        TipoIngrediente.PanBase,
        TipoIngrediente.Carne,
        TipoIngrediente.Queso,
        TipoIngrediente.Cebolla,
        TipoIngrediente.Tomate,
        TipoIngrediente.Lechuga,
        TipoIngrediente.Condimento,
        TipoIngrediente.PanTapa
    };

    private List<Ingrediente> ingredienteEnPosicion = new List<Ingrediente>();

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Ingrediente ing) && !ing.estaListo)
        {
            if(!ingredienteEnPosicion.Contains(ing))
            {
                ingredienteEnPosicion.Add(ing);
            }
        }
    }

}
