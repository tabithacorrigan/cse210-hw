public class Fraction
{
    private int _top;

    private int _bottom;

    public Fraction()
    {
        // default values
        _top = 1;
        _bottom = 1;

    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }


    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFraction()
    {
        return ($"{_top}/{_bottom}");
    }

    public string GetFractionString()
    {
        // per assignment, we dont assign this to a member variable, just a temp variable
        string text = $"{_top}/{_bottom}";

        return text;
    }

    public double GetDecimalValue()
    {
        // per assignment: notice we dont assign this a variable. we allow it to compute

        // the (double) before the variables allows it to return a decimal point
        return (double)_top / (double)_bottom;
    }


    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
}