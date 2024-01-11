namespace EightToTen.Services.GuessIt
{
    public interface IGuessService
    {
        string EasyGuess(string number);

        string MediumGuess(string number);

        string HardGuess(string number);
    }
}