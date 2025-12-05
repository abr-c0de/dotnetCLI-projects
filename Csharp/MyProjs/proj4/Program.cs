int[] testScore = [100, 90, 30, 88, 75, 93];
var lowestScore = testScore[0];
var highestScore = testScore[0];
var sum = 0;



for(int i = 0; i < testScore.Length; i++)
{
    int score = testScore[i];
    if(score < lowestScore)
    {
        lowestScore = score;
    }

    if(score > highestScore)
    {
        highestScore = score;
    }


     sum = sum += score;
    
}

double avg = (double)sum / (double)testScore.Length;

Console.WriteLine($"The highest score is: {highestScore}\nThe lowest score is: {lowestScore}\nThe sum of score is: {sum}\nThe average score is: {avg}");