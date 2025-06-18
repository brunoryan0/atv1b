using UnityEngine;

public class TestePersonagem : MonoBehaviour
{
    void Start()
    {
        // Criando dois personagens
        Arqueiro arqueiro1 = gameObject.AddComponent<Arqueiro>();
        arqueiro1.SetNome("Bruno, o Arqueiro");
        arqueiro1.SetVida(100);
        arqueiro1.SetForca(30);
        arqueiro1.SetNivel(5);

        Arqueiro arqueiro2 = gameObject.AddComponent<Arqueiro>();
        arqueiro2.SetNome("Rival");
        arqueiro2.SetVida(80);
        arqueiro2.SetForca(25);
        arqueiro2.SetNivel(3);

        // Mostrando valores
        Debug.Log("Personagem 1: " + arqueiro1.GetNome());
        Debug.Log("Vida: " + arqueiro1.GetVida());
        Debug.Log("Força: " + arqueiro1.GetForca());
        Debug.Log("Nível: " + arqueiro1.GetNivel());
        Debug.Log("Habilidade: " + arqueiro1.habilidadeEspecial);

        Debug.Log("Personagem 2: " + arqueiro2.GetNome());
        Debug.Log("Maior nível? " + arqueiro1.CompararNivel(arqueiro2));
    }
}
