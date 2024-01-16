using System;

namespace com.Klazapp.Utility
{
    [Serializable]
    public enum EaseType
    {
        Linear = 0,

        InQuad = 1,
        OutQuad = 2,
        InOutQuad = 3,

        InCubic = 4,
        OutCubic = 5,
        InOutCubic = 6,

        InQuart = 7,
        OutQuart = 8,
        InOutQuart = 9,

        InQuint = 10,
        OutQuint = 11,
        InOutQuint = 12,

        InSine = 13,
        OutSine = 14,
        InOutSine = 15,

        InExpo = 16,
        OutExpo = 17,
        InOutExpo = 18,

        InCirc = 19,
        OutCirc = 20,
        InOutCirc = 21,

        InElastic = 22,
        OutElastic = 23,
        InOutElastic = 24,

        InBack = 25,
        OutBack = 26,
        InOutBack = 27,

        InBounce = 28,
        OutBounce = 29,
        InOutBounce = 30,
    }
}