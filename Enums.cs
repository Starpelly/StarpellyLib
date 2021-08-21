namespace Pelly.Enums
{
    public enum StringType : int
    {
        /// <summary>
        /// Both uppercase and lowercase letters in english.
        /// </summary>
        Alpha,
        /// <summary>
        /// All numbers ranging from 0-9
        /// </summary>
        Numeric,
        /// <summary>
        /// Both uppercase and lowercase letters with all numbers ranging from 0-9. (english)
        /// </summary>
        Alphanumeric,
        /// <summary>
        /// All uppercase letters in english.
        /// </summary>
        Uppercase,
        /// <summary>
        /// All lowercase letters in english.
        /// </summary>
        Lowercase,
        /// <summary>
        /// All punctuation marks on the QWERTY keyboard. (Also contains special keys)
        /// </summary>
        Punctuation,
        /// <summary>
        /// All of the above.
        /// </summary>
        ALL
    }

    public enum WindowsCursor : int
    {
        StandardArrowAndSmallHourglass = 32650,
        StandardArrow = 32512,
        Crosshair = 32515,
        Hand = 32649,
        ArrowAndQuestionMark = 32651,
        IBeam = 32513,
        /// <summary>
        /// Obsolete for applications marked version 4.0 or later. 
        /// </summary>
        [System.Obsolete]
        Icon = 32641,
        SlashedCircle = 32648,
        /// <summary>
        /// Obsolete for applications marked version 4.0 or later. Use FourPointedArrowPointingNorthSouthEastAndWest
        /// </summary>
        [System.Obsolete]
        Size = 32640,
        FourPointedArrowPointingNorthSouthEastAndWest = 32646,
        DoublePointedArrowPointingNortheastAndSouthwest = 32643,
        DoublePointedArrowPointingNorthAndSouth = 32645,
        DoublePointedArrowPointingNorthwestAndSoutheast = 32642,
        DoublePointedArrowPointingWestAndEast = 32644,
        VerticalArrow = 32516,
        Hourglass = 32514
    }
}