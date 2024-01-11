namespace EightToTen.Services.GuessIt
{
    public class GuessService : IGuessService
    {

        // Easy begin
        public string EasyGuess(string number)
        {
            Random eRand = new Random();
            int eGuess = eRand.Next(1, 11);
            bool isTrue = int.TryParse(number, out int eUserGuess);

            if(isTrue && eUserGuess <= 10)
            {
                if(eUserGuess == eGuess)
                {
                    return $"You think {eGuess} is right. Well it is, good job.";
                }
                else if(eUserGuess < eGuess)
                {
                    return $"Wrong! {eUserGuess} is to low. The answer is {eGuess}";
                }
                else
                {
                    return $"Wrong! {eUserGuess} is to high. The answer is {eGuess}";
                }
            }
            else
            {
                return "Invaild. Enter a number between 1 - 10.";
            }
        }

        // Easy End


        // Medium Begin
        public string MediumGuess(string number)
        {
            Random mRand = new Random();
            int mGuess = mRand.Next(1, 51);
            bool isTrue = int.TryParse(number, out int mUserGuess);

            if(isTrue && mUserGuess <= 50)
            {
                if(mUserGuess == mGuess)
                {
                    return $"You think {mGuess} is right. Well it is, good job.";
                }
                else if(mUserGuess < mGuess)
                {
                    return $"Wrong! {mUserGuess} is to low. The answer is {mGuess}";
                }
                else
                {
                    return $"Wrong! {mUserGuess} is to high. The answer is {mGuess}";
                }
            }
            else
            {
                return "Invaild. Enter a number between 1 - 50.";
            }
        }

        // Medium End

        // Hard Begin
        public string HardGuess(string number)
        {
            Random hRand = new Random();
            int hGuess = hRand.Next(1, 101);
            bool isTrue = int.TryParse(number, out int hUserGuess);

            if(isTrue && hUserGuess <= 100)
            {
                if(hUserGuess == hGuess)
                {
                    return $"You think {hGuess} is right. Well it is, good job.";
                }
                else if(hUserGuess < hGuess)
                {
                    return $"Wrong! {hUserGuess} is to low. The answer is {hGuess}";
                }
                else
                {
                    return $"Wrong! {hUserGuess} is to high. The answer is {hGuess}";
                }
            }
            else
            {
                return "Invaild. Enter a number between 1 - 100.";
            }
        }

        // Hard End

    }
}