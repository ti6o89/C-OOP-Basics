
public class Pokemon
{
    private string pokemonName;
    private string pokemonType;

    public Pokemon(string pokemonName, string pokemonType)
    {
        this.pokemonName = pokemonName;
        this.pokemonType = pokemonType;
    }

    public string PokemonName
    {
        get { return this.pokemonName; }
    }

    public string PokemonType
    {
        get { return this.pokemonType; }
    }
}
