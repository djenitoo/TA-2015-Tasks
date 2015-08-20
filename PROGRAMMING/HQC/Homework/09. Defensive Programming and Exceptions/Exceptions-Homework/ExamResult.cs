using System;

public class ExamResult
{
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("Grade cannot be less than zero!");
        }

        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("Min grade cannot be less than zero!");
        }

        if (maxGrade <= minGrade)
        {
            throw new ArgumentOutOfRangeException("Max grade cannot be less than min grade!");
        }

        if (comments == null || comments == string.Empty)
        {
            throw new ArgumentNullException("Comments cannot be null or empty!");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade { get; private set; }

    public int MinGrade { get; private set; }

    public int MaxGrade { get; private set; }

    public string Comments { get; private set; }
}
