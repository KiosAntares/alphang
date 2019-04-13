class Lexer
{
    private string buffer;
    private Ruleset ruleset;

    public Lexer(string buffer, Ruleset ruleset){
        this.buffer = buffer;
        this.ruleset = ruleset;
    }
}