using UnityEngine;

public class Personagem : MonoBehaviour
{
    // Variáveis 
    public string nome;
    public int vida;
    public int forca;
    public int nivel;

    // Funções de leitura e escrita
    public void SetNome(string novoNome) { nome = novoNome; }
    public string GetNome() { return nome; }

    public void SetVida(int novaVida) { vida = novaVida; }
    public int GetVida() { return vida; }

    public void SetForca(int novaForca) { forca = novaForca; }
    public int GetForca() { return forca; }

    public void SetNivel(int novoNivel) { nivel = novoNivel; }
    public int GetNivel() { return nivel; }

    // Comparação entre dois personagens
    public bool CompararNivel(Personagem outro)
    {
        return nivel > outro.nivel;
    }
}
